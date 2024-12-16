using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication8.Data;
using WebApplication8.Models;

namespace WebApplication8.Pages.RequestRemonts
{
    public class EditModel : PageModel
    {
        private readonly WebApplication8.Data.WebApplication8Context _context;

        public EditModel(WebApplication8.Data.WebApplication8Context context)
        {
            _context = context;
        }

        [BindProperty]
        public RequestRemont RequestRemont { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.RequestRemont == null)
            {
                return NotFound();
            }

            var requestremont =  await _context.RequestRemont.FirstOrDefaultAsync(m => m.ID == id);
            if (requestremont == null)
            {
                return NotFound();
            }
            RequestRemont = requestremont;
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

            _context.Attach(RequestRemont).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RequestRemontExists(RequestRemont.ID))
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

        private bool RequestRemontExists(int id)
        {
          return (_context.RequestRemont?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
