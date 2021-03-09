using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder) 
        {
            builder.ToTable("Car");
            builder.HasKey(x => x.Id);

            //builder.Property(x => x.Brand).IsRequired();
            //builder.Property(x => x.Color).IsRequired();
            builder.Property(x => x.ModelYear).HasMaxLength(100).IsRequired();
            builder.Property(x => x.DailyPrice).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(100).IsRequired();
        }
    }
}
