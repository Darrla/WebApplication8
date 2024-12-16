using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication8.Data;
using WebApplication8.Models;

namespace WebApplication8.Pages.RequestExecutes
{
    public class DetailsModel : PageModel
    {
        private readonly WebApplication8.Data.WebApplication8Context _context;

        public DetailsModel(WebApplication8.Data.WebApplication8Context context)
        {
            _context = context;
        }

      public RequestExecute RequestExecute { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.RequestExecute == null)
            {
                return NotFound();
            }

            var requestexecute = await _context.RequestExecute.FirstOrDefaultAsync(m => m.ID == id);
            if (requestexecute == null)
            {
                return NotFound();
            }
            else 
            {
                RequestExecute = requestexecute;
            }
            return Page();
        }
    }
}
