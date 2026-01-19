using EFIndentityDemo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
{
    public void Configure(EntityTypeBuilder<AppUser> builder)
    {
        // Şehir alanı için kısıtlamalar
        builder.Property(x => x.City)
            .HasMaxLength(50);

        // Profil resmi yolu/URL alanı
        builder.Property(x => x.Picture)
            .HasMaxLength(250);

        // Doğum tarihi alanı (İsteğe bağlı kısıtlamalar eklenebilir)
        builder.Property(x => x.BirthDate)
            .HasColumnType("datetime2");

        // Cinsiyet alanı (Enum olarak saklanır, veritabanında genellikle int tutulur)
        builder.Property(x => x.Gender)
            .IsRequired(false);

        /* IdentityUser'dan gelen diğer alanları (Email, UserName vb.) 
           değiştirmek istersen burada yapabilirsin. 
           Örn: builder.Property(u => u.Email).HasMaxLength(100);
        */

        // Tablo ismini değiştirmek istersen:
        // builder.ToTable("Users");
    }
}