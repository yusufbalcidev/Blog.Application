using Blog.Application.Models.Base;

namespace Blog.Application.Models.Entities
{
    public class About : BaseEntity
    {
        public string? FotoUrl { get; set; }
        public string Description { get; set; }
    }
}
