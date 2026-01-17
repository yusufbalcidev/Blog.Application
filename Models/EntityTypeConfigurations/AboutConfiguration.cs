using Blog.Application.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Blog.Application.Models.EntityTypeConfigurations
{
    public class AboutConfiguration:BaseEntityTypeConfiguration<About>
    {
        override public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<About> builder)
        {
            builder.ToTable(name: "About", schema: "blg");
            builder.Property(a => a.FotoUrl)
                .HasMaxLength(250)
                .IsRequired(false);
                
            
            builder.Property(a => a.Description)
                .HasMaxLength(5000)
                .IsRequired();
            base.Configure(builder);

        }

    }
}
