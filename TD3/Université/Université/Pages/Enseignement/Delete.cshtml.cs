﻿using System;
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
    public class DeleteModel : PageModel
    {
        private readonly Université.ApplicationDbContext _context;

        public DeleteModel(Université.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Enseigner Enseigner { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Enseigner = await _context.Enseigner
                .Include(e => e.LUE)
                .Include(e => e.Lenseignant).FirstOrDefaultAsync(m => m.ID == id);

            if (Enseigner == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Enseigner = await _context.Enseigner.FindAsync(id);

            if (Enseigner != null)
            {
                _context.Enseigner.Remove(Enseigner);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index", new {id = Enseigner.LenseignantID});
        }
    }
}
