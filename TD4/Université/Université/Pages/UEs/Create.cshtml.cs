using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Université;
using Université.Entity;

namespace Université.Pages.UEs
{
    public class CreateModel : PageModel
    {
        private readonly Université.ApplicationDbContext _context;

        public CreateModel(Université.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["FormationID"] = new SelectList(_context.Formation, "ID", "Intitule");
            return Page();
        }

        [BindProperty]
        public UE UE { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.UE.Add(UE);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
