using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Université.Models;
using Université.Models.Entity;

namespace Université.Pages.Etudiants
{
    public class CreateModel : PageModel
    {
        private readonly Université.Models.ApplicationDbContext _context;

        public CreateModel(Université.Models.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Etudiant Etudiant { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Etudiant.Add(Etudiant);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
