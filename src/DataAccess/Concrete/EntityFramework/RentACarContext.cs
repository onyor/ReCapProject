using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using DataAccess.Abstract;
using Microsoft.Extensions.Configuration;

namespace DataAccess.Concrete.EntityFramework
{
    public class RentACarContext : DbContext, IRentACarContext
    {
        //public RentACarContext(
        //    DbContextOptions<RentACarContext> options
        //) : base(options)
        //{

        //}
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Color> Colors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //optionsBuilder.UseSqlServer(@"Server=DESKTOP-M5HS3EJ;Database=RentACarDB;User Id=sa;Password=123");
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-8KUDCNR;Database=RentACarDB;User Id=sa;Password=123");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }
    }
}
