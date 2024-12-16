using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication8.Models;

namespace WebApplication8.Data
{
    public class WebApplication8Context : DbContext
    {
        public WebApplication8Context (DbContextOptions<WebApplication8Context> options)
            : base(options)
        {
        }

        public DbSet<WebApplication8.Models.RequestRemont> RequestRemont { get; set; } = default!;

        public DbSet<WebApplication8.Models.RequestRegistary> RequestRegistary { get; set; } = default!;

        public DbSet<WebApplication8.Models.RequestProcessor> RequestProcessor { get; set; } = default!;

        public DbSet<WebApplication8.Models.RequestExecute> RequestExecute { get; set; } = default!;

        public DbSet<WebApplication8.Models.Report> Report { get; set; } = default!;

        public DbSet<WebApplication8.Models.Monitoring> Monitoring { get; set; } = default!;

        public DbSet<WebApplication8.Models.Client> Client { get; set; } = default!;

        public DbSet<WebApplication8.Models.Executor> Executor { get; set; } = default!;
    }
}
