using Advisor6.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Advisor6.Data
{
    public class AppDbContext: DbContext

    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
           
        }



        public DbSet<Personal> Personal { get; set; }
        public DbSet<Employment_info> Employment_info { get; set; }     
        public DbSet<Administrative_Orders> Administrative_Orders { get; set; }
        

    }
}
