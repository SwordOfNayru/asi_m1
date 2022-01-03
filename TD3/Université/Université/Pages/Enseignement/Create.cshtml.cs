using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Université;
using Université.Entity;

namespace Université.Pages.Enseignement
{
    public class CreateModel : PageModel
    {
        private readonly Université.ApplicationDbContext _context;

        public CreateModel(Université.ApplicationDbContext context)
        {
            _context = context;
        }

        public Enseignant Enseignant { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            ViewData["LUEID"] = new SelectList(_context.UE, "ID", "Intitule");
            Enseignant = await _context.Enseignant.FindAsync(id.Value);
            return Page();
        }

        [BindProperty]
        public Enseigner Enseigner { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Enseigner.Add(Enseigner);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index", new { id = Enseigner.LenseignantID });
        }
    }
}
