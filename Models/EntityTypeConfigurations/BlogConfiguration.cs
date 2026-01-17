using Blog.Application.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Application.Models.EntityTypeConfigurations
{
    public class BlogConfiguration : BaseEntityTypeConfiguration<Blogs>
    {

        public override void Configure(EntityTypeBuilder<Blogs> builder)
        {
            builder.ToTable(name: "Blog", schema: "blg");
            base.Configure(builder);

            builder.Property(b => b.Title).HasMaxLength(200).IsRequired();
            builder.Property(b => b.Description).HasMaxLength(5000).IsRequired();
            builder.Property(b => b.BlogImage).HasMaxLength(250).IsRequired(false);

            // --- HATA ÇÖZÜMÜ: Gölge sütun (AdminsId) oluşmasını engeller ---
            builder.HasOne(x => x.Admins)       // Blogs içindeki property adı
                   .WithMany(x => x.Blogs)      // Admins içindeki property adı
                   .HasForeignKey(x => x.AdminId) // Mevcut olan AdminId'yi kullan
                   .IsRequired();
        }
    }
}
