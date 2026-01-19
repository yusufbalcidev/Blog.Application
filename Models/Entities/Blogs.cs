using Blog.Application.Models.Base;
using EFIndentityDemo.Models;

namespace Blog.Application.Models.Entities
{
    public class Blogs : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string BlogImage { get; set; }

        // Identity AppUser ile yazar ilişkisi

        public int AdminId { get; set; }
        public virtual Admins Admins { get; set; }


        // --- HATA ÇÖZÜMÜ ---
        // Configuration'daki .WithMany(b => b.Comments) kısmının çalışması için bu gereklidir.
        public virtual ICollection<Comments> Comments { get; set; }



    }
}
