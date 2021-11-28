using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sava_Camelia_Lab8.Models;

namespace Sava_Camelia_Lab8.Data
{
    public class Sava_Camelia_Lab8Context : DbContext
    {
        public Sava_Camelia_Lab8Context (DbContextOptions<Sava_Camelia_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Sava_Camelia_Lab8.Models.Book> Book { get; set; }

        public DbSet<Sava_Camelia_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Sava_Camelia_Lab8.Models.Category> Category { get; set; }
    }
}
