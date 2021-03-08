using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Microsoft.Extensions.Configuration;

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
