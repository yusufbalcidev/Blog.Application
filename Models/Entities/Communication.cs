using Blog.Application.Models.Base;
using Microsoft.AspNetCore.Identity;

namespace Blog.Application.Models.Entities
{
    public class Communication : BaseEntity
    {
        
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
