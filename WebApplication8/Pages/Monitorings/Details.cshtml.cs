using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication8.Data;
using WebApplication8.Models;

namespace WebApplication8.Pages.Monitorings
{
    public class DetailsModel : PageModel
    {
        private readonly WebApplication8.Data.WebApplication8Context _context;

        public DetailsModel(WebApplication8.Data.WebApplication8Context context)
        {
            _context = context;
        }

      public Monitoring Monitoring { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Monitoring == null)
            {
                return NotFound();
            }

            var monitoring = await _context.Monitoring.FirstOrDefaultAsync(m => m.ID == id);
            if (monitoring == null)
            {
                return NotFound();
            }
            else 
            {
                Monitoring = monitoring;
            }
            return Page();
        }
    }
}
