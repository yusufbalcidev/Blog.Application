using Blog.Application.Models.Base;

namespace Blog.Application.Models.Entities
{
    public class Admins : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }



        public ICollection<Blogs> Blogs { get; set; }
    }
}
