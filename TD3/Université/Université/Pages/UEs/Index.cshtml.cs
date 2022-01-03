using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Université;
using Université.Entity;

namespace Université.Pages.UEs
{
    public class IndexModel : PageModel
    {
        private readonly Université.ApplicationDbContext _context;

        public IndexModel(Université.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<UE> UE { get;set; }

        public async Task OnGetAsync()
        {
            UE = await _context.UE
                .Include(u => u.Formation).ToListAsync();
        }
    }
}
