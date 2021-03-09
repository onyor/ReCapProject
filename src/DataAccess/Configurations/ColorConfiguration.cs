using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class ColorConfiguration: IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.ToTable("Colorasdasd");
            builder.HasKey(x => x.ColorId);

            builder.Property(x => x.ColorName).HasMaxLength(100).IsRequired();
        }
    }
}
