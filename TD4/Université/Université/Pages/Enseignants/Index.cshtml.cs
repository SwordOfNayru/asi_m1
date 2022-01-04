using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Université;
using Université.Entity;

namespace Université.Pages.Enseignants
{
    public class IndexModel : PageModel
    {
        private readonly Université.ApplicationDbContext _context;

        public IndexModel(Université.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Enseignant> Enseignant { get;set; }

        public async Task OnGetAsync()
        {
            Enseignant = await _context.Enseignant.ToListAsync();
        }
    }
}
