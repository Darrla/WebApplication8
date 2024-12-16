﻿using System;
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
    public class IndexModel : PageModel
    {
        private readonly WebApplication8.Data.WebApplication8Context _context;

        public IndexModel(WebApplication8.Data.WebApplication8Context context)
        {
            _context = context;
        }

        public IList<RequestRegistary> RequestRegistary { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.RequestRegistary != null)
            {
                RequestRegistary = await _context.RequestRegistary.ToListAsync();
            }
        }
    }
}
