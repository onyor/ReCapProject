using Entities.Concrete;
using System.Data.Entity.ModelConfiguration;

namespace Entities.Tables
{
    public class BrandTable : EntityTypeConfiguration<Brand>
    {
        public BrandTable()
        {
            //this.HasKey(t => t.BrandId);

            //this.Property(t => t.BrandName)
            //    .IsRequired();

            //this.ToTable("brands");
            //this.Property(t => t.BrandId).HasColumnName("BrandId");
            //this.Property(t => t.BrandName).HasColumnName("BrandName");
        }
    }
}
