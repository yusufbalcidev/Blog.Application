using Blog.Application.Models.Entities;
using Microsoft.AspNetCore.Identity;

namespace EFIndentityDemo.Models
{
    public class AppUser:IdentityUser
    {
        public string? City { get; set; }
        public string? Picture { get; set; }
        public DateTime? BirthDate { get; set; }
        public Gender? Gender { get; set; }

        public virtual ICollection<Comments> Comments { get; set; }

    }
}
