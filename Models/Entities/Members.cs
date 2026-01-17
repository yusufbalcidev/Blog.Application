using Blog.Application.Models.Base;

namespace Blog.Application.Models.Entities
{
    public class Members : BaseEntity
    {
        public string Firstame  { get; set; }
        public string LastName  { get; set; }

        public string Age { get; set; }
        public string Email { get; set; }

        public string PassWord { get; set; }
        public int PhoneNumber { get; set; }

        public ICollection<Comments> Comments { get; set; }

    }
}
