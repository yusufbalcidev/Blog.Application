using Blog.Application.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Blog.Application.Models.EntityTypeConfigurations
{
    public class CommunicationConfiguration : BaseEntityTypeConfiguration<Communication>
    {

        override public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Communication> builder)
        {
            builder.ToTable(name: "Communication", schema: "blg");

            base.Configure(builder);
            builder.Property(c => c.Name)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(c => c.Email)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(c => c.Subject)
                .HasMaxLength(200)
                .IsRequired();
            builder.Property(c => c.Message)
               .HasMaxLength(2000)
               .IsRequired();
        }


    }
}
