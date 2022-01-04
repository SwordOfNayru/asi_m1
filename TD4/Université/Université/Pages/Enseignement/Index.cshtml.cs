using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Université;
using Université.Entity;

namespace Université.Pages.Enseignement
{
    public class IndexModel : PageModel
    {
        private readonly Université.ApplicationDbContext _context;

        public IndexModel(Université.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Enseigner> Enseigner { get;set; }
        public int EnseignantID { get; set; }
        public Enseignant Enseignant { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            EnseignantID = id.Value;

            Enseignant = _context.Enseignant.Find(EnseignantID);

            Enseigner = await _context.Enseigner
                .Include(e => e.Lenseignant)
                .Include(e => e.LUE)
                .Where(e => e.LenseignantID == EnseignantID)
                .ToListAsync();

            if(Enseigner == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
