﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Université;
using Université.Entity;

namespace Université.Pages.Enseignement
{
    public class EditModel : PageModel
    {
        private readonly Université.ApplicationDbContext _context;

        public EditModel(Université.ApplicationDbContext context)
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
           ViewData["LUEID"] = new SelectList(_context.UE, "ID", "Intitule");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Enseigner).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EnseignerExists(Enseigner.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index", new {id = Enseigner.LenseignantID});
        }

        private bool EnseignerExists(int id)
        {
            return _context.Enseigner.Any(e => e.ID == id);
        }
    }
}
