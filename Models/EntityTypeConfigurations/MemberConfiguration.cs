using Blog.Application.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Blog.Application.Models.EntityTypeConfigurations
{
    public class MemberConfiguration : BaseEntityTypeConfiguration<Members>
    {

        override public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Members> builder)
        {
            builder.ToTable(name: "Members", schema: "blg");

            base.Configure(builder);
            builder.Property(m => m.Firstame)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(m => m.LastName)

                .IsRequired()
                .HasMaxLength(50);
            builder.Property(m => m.Age)
                .IsRequired();
            builder.Property(m => m.Email)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(m => m.PassWord)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(m => m.PhoneNumber)
                .IsRequired();

        }
    }
}
