using Blog.Application.Models.Base;
using Blog.Application.Models.Entities;
using EFIndentityDemo.Models;

public class Comments : BaseEntity
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string CommentSubject { get; set; }
    public string CommentText { get; set; }

    public string? AppUserId { get; set; }
    public virtual AppUser? AppUser { get; set; }   // nullable

    public int BlogId { get; set; }
    public virtual Blogs? Blogs { get; set; }       // nullable (seed’de null yapıyorsun)
}
