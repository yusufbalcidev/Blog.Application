using Blog.Application.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Blog.Application.Models.EntityTypeConfigurations
{
    public class AdminConfiguration : BaseEntityTypeConfiguration<Admins>
    {
        override public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Admins> builder)
        {
            builder.ToTable(name: "Admin", schema: "blg");

            base.Configure(builder);
            builder.Property(a => a.UserName)
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(a => a.Password)
                .HasMaxLength(50)
                .IsRequired();
            
        }

    }
}
