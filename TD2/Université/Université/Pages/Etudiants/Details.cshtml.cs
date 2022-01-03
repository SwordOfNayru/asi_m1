using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Université.Models;
using Université.Models.Entity;

namespace Université.Pages.Etudiants
{
    public class DetailsModel : PageModel
    {
        private readonly Université.Models.ApplicationDbContext _context;

        public DetailsModel(Université.Models.ApplicationDbContext context)
        {
            _context = context;
        }

        public Etudiant Etudiant { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Etudiant = await _context.Etudiant.FirstOrDefaultAsync(m => m.ID == id);

            if (Etudiant == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
