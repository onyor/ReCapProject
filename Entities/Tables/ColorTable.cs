using Entities.Concrete;
using System.Data.Entity.ModelConfiguration;

namespace Entities.Tables
{
    public class ColorTable : EntityTypeConfiguration<Color>
    {
        public ColorTable()
        {
        //    this.HasKey(t => t.ColorId);

        //    this.Property(t => t.ColorName)
        //        .IsRequired();

        //    this.ToTable("colors");
        //    this.Property(t => t.ColorId).HasColumnName("ColorId");
        //    this.Property(t => t.ColorName).HasColumnName("ColorName");
        }
    }
}
