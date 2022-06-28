using Advisor6.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Advisor6.Data
{
    public class AppDbContext: IdentityDbContext<ApplicationUser>

    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
           
        }

        public DbSet<Personal> Personal { get; set; }
        public DbSet<Employment_info> Employment_info { get; set; }     
        public DbSet<Administrative_Orders> Administrative_Orders { get; set; }
        public DbSet<Academic_Cert> Academic_Cert { get; set; }
        public DbSet<Ifad> Ifad { get; set; }
        public DbSet<Thanks> Thanks { get; set; }
        public DbSet<Trining> Trining { get; set; }
        public DbSet<Vacations> Vacations { get; set; }

    }
}
