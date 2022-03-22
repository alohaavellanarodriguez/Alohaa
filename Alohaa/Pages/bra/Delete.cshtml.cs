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
    public class DeleteModel : PageModel
    {
        private readonly Alohaa.Data.AlohaaContext _context;

        public DeleteModel(Alohaa.Data.AlohaaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public pogi pogi { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            pogi = await _context.pogi.FirstOrDefaultAsync(m => m.ID == id);

            if (pogi == null)
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

            pogi = await _context.pogi.FindAsync(id);

            if (pogi != null)
            {
                _context.pogi.Remove(pogi);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
