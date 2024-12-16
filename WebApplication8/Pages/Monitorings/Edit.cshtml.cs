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

namespace WebApplication8.Pages.Monitorings
{
    public class EditModel : PageModel
    {
        private readonly WebApplication8.Data.WebApplication8Context _context;

        public EditModel(WebApplication8.Data.WebApplication8Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Monitoring Monitoring { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Monitoring == null)
            {
                return NotFound();
            }

            var monitoring =  await _context.Monitoring.FirstOrDefaultAsync(m => m.ID == id);
            if (monitoring == null)
            {
                return NotFound();
            }
            Monitoring = monitoring;
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

            _context.Attach(Monitoring).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MonitoringExists(Monitoring.ID))
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

        private bool MonitoringExists(int id)
        {
          return (_context.Monitoring?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
