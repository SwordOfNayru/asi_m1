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
    public class IndexModel : PageModel
    {
        private readonly Université.Models.ApplicationDbContext _context;

        public IndexModel(Université.Models.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Etudiant> Etudiant { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public async Task OnGetAsync()
        {
            //Etudiant = await _context.Etudiant.ToListAsync();
            var e = from etud in _context.Etudiant select etud;

            if (!string.IsNullOrEmpty(SearchString))
                e = e.Where(s => s.Nom.Contains(SearchString));
            Etudiant = await e.ToListAsync();
        }
    }
}
