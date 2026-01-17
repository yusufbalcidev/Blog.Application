using Blog.Application.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Blog.Application.Models.EntityTypeConfigurations
{
    public class CommentConfiguration : BaseEntityTypeConfiguration<Comments>
    {   
        override public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Comments> builder)
        {
            builder.ToTable(name: "Comment", schema: "blg");

            base.Configure(builder);
            builder.Property(c => c.Name)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(c => c.Email)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(c => c.CommentSubject)
                .HasMaxLength(2000)
                .IsRequired();
            builder.Property(c => c.CommentText)
               .HasMaxLength(2000)
               .IsRequired();
            builder.HasOne(c => c.Members)
           .WithMany(m => m.Comments)
           .HasForeignKey(c => c.MemberId)
           .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
