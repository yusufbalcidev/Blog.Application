using Blog.Application.Models.Base;

namespace Blog.Application.Models.Entities
{
    public class Comments : BaseEntity
    
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string CommentSubject { get; set; }
        public string CommentText { get; set; }

        public int MemberId { get; set; }
        virtual public Members Members { get; set; }
    }
}
