using System.Formats.Tar;
using Blog.Application.Models.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Application.Models.EntityTypeConfigurations
{
    public class BaseEntityTypeConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.CreatedDate)
            .HasColumnType("datetime2");
            //.HasDefaultValue(DateTime.Now)
            //.HasDefaultValueSql("getdate()");


            //kullanicagimiz veri tabanina gore 
            //.HasColumnType("timestamp"); olabilir datetime hepsi desteklemez

            builder.Property(e => e.UpdatedDate)
            .HasColumnType("datetime2")
            .IsRequired(false);
        }

        
    }
}
