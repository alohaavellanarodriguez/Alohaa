#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Alohaa.Data;
using Alohaa.models;

namespace Alohaa.Pages.bra
{
    public class CreateModel : PageModel
    {
        private readonly Alohaa.Data.AlohaaContext _context;

        public CreateModel(Alohaa.Data.AlohaaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public pogi pogi { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.pogi.Add(pogi);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
