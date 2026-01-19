using Blog.Application.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class CommentsConfiguration : IEntityTypeConfiguration<Comments>
{
    public void Configure(EntityTypeBuilder<Comments> builder)
    {
        // BlogId = FK olsun (BlogsId shadow FK oluşmasın)
        builder.HasOne(c => c.Blogs)
               .WithMany() // Blogs entity’de Comments koleksiyonu yoksa böyle
               .HasForeignKey(c => c.BlogId)
               .OnDelete(DeleteBehavior.Cascade);

        // AppUser opsiyonel olsun (AppUserId null gelebiliyor)
        builder.HasOne(c => c.AppUser)
               .WithMany()
               .HasForeignKey(c => c.AppUserId)
               .IsRequired(false)
               .OnDelete(DeleteBehavior.SetNull);
    }
}
