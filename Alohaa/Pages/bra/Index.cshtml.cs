#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Alohaa.Data;
using Alohaa.models;

namespace Alohaa.Pages.bra
{
#pragma warning disable
#pragma warning disable
    public class IndexModel : PageModel
    {
        private readonly Alohaa.Data.AlohaaContext _context;

        public IndexModel(Alohaa.Data.AlohaaContext context)
        {
            _context = context;
        }

        public IList<pogi> pogi { get;set; }

        public async Task OnGetAsync()
        {
            pogi = await _context.pogi.ToListAsync();
        }
#pragma warning restore
#pragma warning restore
    }
}
