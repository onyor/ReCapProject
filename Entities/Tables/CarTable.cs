using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace Entities.Tables
{
    public class CarTable: EntityTypeConfiguration<Car>
    {
        public CarTable()
        {
            //this.HasKey(t => t.Id);

            //this.Property(t => t.ModelYear)
            //    .IsRequired();

            //this.Property(t => t.DailyPrice)
            //    .IsRequired();

            //this.Property(t => t.Description)
            //    .IsRequired()
            //    .HasMaxLength(40);

            //this.ToTable("cars");
        }
    }
}
