using Blog.Application.Models.Base;

namespace Blog.Application.Models.Entities
{
    public class Blogs: BaseEntity
    {
        public string Title { get; set; }

        public string Description { get; set; }
        public string BlogImage { get; set; }

        public int AdminId { get; set; }

        public Admins Admins { get; set; }

    }
}
