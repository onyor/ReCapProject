using Entities.Concrete;
using Entities.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class RentACarContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-8KUDCNR;Database=RentACarContext;User Id=sa;Password=123");
        }

        public DbSet<Brand> brands { get; set; }
        public DbSet<Car> cars { get; set; }
        public DbSet<Color> colors { get; set; }

    }
}
