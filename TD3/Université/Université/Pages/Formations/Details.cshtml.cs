using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Université;
using Université.Entity;

namespace Université.Pages.Formations
{
    public class DetailsModel : PageModel
    {
        private readonly Université.ApplicationDbContext _context;

        public DetailsModel(Université.ApplicationDbContext context)
        {
            _context = context;
        }

        public Formation Formation { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Formation = await _context.Formation.Include(formation => formation.EtudiantsInscrits).Include(formation => formation.UEProposee).FirstOrDefaultAsync(m => m.ID == id);

            if (Formation == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
