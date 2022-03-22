#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Alohaa.Data;
using Alohaa.models;

namespace Alohaa.Pages.bra
{
    public class EditModel : PageModel
    {
        private readonly Alohaa.Data.AlohaaContext _context;

        public EditModel(Alohaa.Data.AlohaaContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(pogi).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!pogiExists(pogi.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool pogiExists(int id)
        {
            return _context.pogi.Any(e => e.ID == id);
        }
    }
}
