using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Université.Entity;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Université.Pages.Notes
{
    public class EditModel : PageModel
    {
        private readonly Université.ApplicationDbContext _context;

        public NoteMode Mode { get; set; }
        public UE UE { get; set; }

        public List<Note> Notes { get; set; }

        public List<string> Errors { get; set; }

        public EditModel(Université.ApplicationDbContext context)
        {
            _context = context;
            Errors = new List<string>();
        }

        public IActionResult OnGet()
        {
            ViewData["LUEID"] = new SelectList(_context.UE, "ID", "Intitule");
            Mode = NoteMode.UeChoice;
            return Page();
        }

        public async Task<IActionResult> OnPostUEAsync([FromForm]int id)
        {
            Mode = NoteMode.List;
            this.UE = await _context.UE
                .Include(e => e.Formation)
                .ThenInclude(e => e.EtudiantsInscrits)
                .FirstOrDefaultAsync(e => e.ID == id);
            
            if(this.UE == null)
            {
                return NotFound();
            }

            Notes = await RefreshNote(id);

            return Page();
        }

        //La fonction a un défaut UX si une notes n'est pas valide aucune n'est validé.
        //Ce n'est pas vraiment demandé dans la consigne.
        //-1 est considéré comme une absence
        public async Task<IActionResult> OnPostNoteAsync([FromForm] int UEID, [FromForm]List<ListeEtudiant> listeEtud)
        {
            //Ce block est inclus car le controlleur ne garde pas les propriété en mémoire.
            this.UE = await _context.UE
                .Include(e => e.Formation)
                .ThenInclude(e => e.EtudiantsInscrits)
                .FirstOrDefaultAsync(e => e.ID == UEID);

            Notes = await RefreshNote(UEID);

            Errors = new List<string>();

            //J'isole la transaction pour pouvoir la RollBack si il y a une erreur
            using var transaction = _context.Database.BeginTransaction();

            //Le foreach est un peu complexe c'est la vérification étape par étape
            foreach(var etud in listeEtud)
            {
                //Je récuppère l'étudiant
                Etudiant etudiant = UE.Formation.EtudiantsInscrits.FirstOrDefault(e => e.ID == etud.EtudiantId);
                if(etudiant == null)
                {
                    Errors.Add($"L'étudiant {etud.EtudiantId} n'existe pas");
                    continue;
                }

                //Note valeur peut être null. Pour effacer en même temps les notes avec des entrées qui ont des espaces
                //je remplace la valeur null par une chaine vide pour être considéré a supprimer.
                if(etud.NoteValeur == null)
                {
                    etud.NoteValeur = "";
                }
                else
                {
                    //Retire tout les espaces de la valeur
                    etud.NoteValeur = Regex.Replace(etud.NoteValeur, @"\s", "");
                }

                //Si c'est null
                //Suppression ou non note
                if(etud.NoteValeur == "")
                {
                    if(Notes.Any(e => e.RelationEtudiant.LEtudiantID == etudiant.ID))
                    {
                        _context.Note.Remove(Notes.FirstOrDefault(e => e.RelationEtudiant.LEtudiantID == etudiant.ID));
                        _context.SaveChanges();
                    }
                    continue;
                }

                //Verification que c'est bien une note qui est rentré
                float note;
                if(float.TryParse(etud.NoteValeur, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.CreateSpecificCulture("fr-FR"), out note)) //Try parse pour savoir si c'est bien un float
                {
                    //Je verifie le range
                    if(note < -1 && note > 20)
                    {
                        Errors.Add($"La note {note} de l'étudiant {etudiant.NomComplet} n'est pas dans l'écart -1 > x > 20");
                    }
                    else
                    {
                        //Je verifie si l'étudiant a déjà une note
                        if(Notes.Any(e => e.RelationEtudiant.LEtudiantID == etudiant.ID))
                        {
                            Note noteModifier = Notes.FirstOrDefault(e => e.RelationEtudiant.LEtudiantID == etudiant.ID);
                            noteModifier.Valeur = note;
                            _context.Note.Update(noteModifier);
                        }
                        else
                        {
                            Etudier etudier = _context.Etudier.FirstOrDefault(e => e.LEtudiantID == etudiant.ID && e.LUEID == UE.ID);
                            
                            //Je verifie que le lien entre matière et etudiant est bien fait.
                            //Ici note ressemble plus à une porteuse de donnée mais dans la base 
                            //Il y a une entité qui fais office du Many to Many qui n'est pas Note
                            //Donc j'ai une vérification en plus
                            if(etudier == null)
                            {
                                etudier = new Etudier()
                                {
                                    LUEID = UE.ID,
                                    LEtudiantID = etudiant.ID,
                                };
                                _context.Etudier.Add(etudier);
                                _context.SaveChanges();
                            }

                            _context.Note.Add(new Note()
                            {
                                Valeur = note,
                                RelationEtudiant = etudier
                            });
                            _context.SaveChanges();
                        }
                    }

                }
                else
                {
                    Errors.Add($"La note {etud.NoteValeur} de l'étudiant {etudiant.NomComplet} n'est pas valide");
                }
            }

            if(Errors.Count > 0)
            {
                transaction.Rollback();
            }
            else
            {
                transaction.Commit();

                Notes = await RefreshNote(UEID);
            }

            Mode = NoteMode.List;

            return Page();
        }

        private async Task<List<Note>> RefreshNote(int UEID)
        {
            return await _context.Note
                .Include(e => e.RelationEtudiant)
                .ThenInclude(e => e.LEtudiant)
                .Where(e => e.RelationEtudiant.LUEID.Value == UEID)
                .ToListAsync();
        }

        public enum NoteMode
        {
            None = 0,
            UeChoice = 1,
            List = 2
        }

        public class ListeEtudiant
        {
            public int EtudiantId { get; set; }

            public string NoteValeur { get; set; }
        }
    }
}
