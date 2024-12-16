using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication8.Data;
using WebApplication8.Models;

namespace WebApplication8.Pages.RequestRegistarys
{
    public class DeleteModel : PageModel
    {
        private readonly WebApplication8.Data.WebApplication8Context _context;

        public DeleteModel(WebApplication8.Data.WebApplication8Context context)
        {
            _context = context;
        }

        [BindProperty]
      public RequestRegistary RequestRegistary { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.RequestRegistary == null)
            {
                return NotFound();
            }

            var requestregistary = await _context.RequestRegistary.FirstOrDefaultAsync(m => m.ID == id);

            if (requestregistary == null)
            {
                return NotFound();
            }
            else 
            {
                RequestRegistary = requestregistary;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.RequestRegistary == null)
            {
                return NotFound();
            }
            var requestregistary = await _context.RequestRegistary.FindAsync(id);

            if (requestregistary != null)
            {
                RequestRegistary = requestregistary;
                _context.RequestRegistary.Remove(RequestRegistary);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
