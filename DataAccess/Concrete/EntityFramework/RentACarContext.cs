using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class RentACarContext : DbContext
    {

        public RentACarContext(
            DbContextOptions<RentACarContext> options
        ) : base(options)
        {

        }
        public RentACarContext()
        {

        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=DESKTOP-8KUDCNR;Database=RentACarContext;User Id=sa;Password=123");
        //}

        public virtual DbSet<Brand> brands { get; set; }
        public virtual DbSet<Car> cars { get; set; }
        public virtual DbSet<Color> colors { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}
