using Bogus;
using Blog.Application.Models.Entities;

namespace Blog.Application.DataGenerator
{
    public static class BlogDataGenerator
    {
        public static List<Admins> GenerateAdmins(int count)
        {
            var faker = new Faker<Admins>("tr")
                .RuleFor(a => a.Id, f => f.IndexFaker + 1) // Manuel ID şart
                .RuleFor(a => a.CreatedDate, f => f.Date.Past(2))
                .RuleFor(a => a.UserName, f => f.Internet.UserName())
                .RuleFor(a => a.Password, f => f.Internet.Password(8));

            return faker.Generate(count);
        }

        public static List<Members> GenerateMembers(int count)
        {
            var faker = new Faker<Members>("tr")
                .RuleFor(m => m.Id, f => f.IndexFaker + 1) // Manuel ID şart
                .RuleFor(m => m.Firstame, f => f.Name.FirstName())
                .RuleFor(m => m.LastName, f => f.Name.LastName())
                .RuleFor(m => m.Age, f => f.Random.Number(18, 65).ToString())
                .RuleFor(m => m.Email, f => f.Internet.Email())
                .RuleFor(m => m.PassWord, f => f.Internet.Password())
                .RuleFor(m => m.PhoneNumber, f => f.Random.Number(1000000, 9999999))
                .RuleFor(m => m.CreatedDate, f => f.Date.Past(1));

            return faker.Generate(count);
        }

        public static List<Blogs> GenerateBlogs(int count, List<Admins> admins)
        {
            var faker = new Faker<Blogs>("tr")
                .RuleFor(b => b.Id, f => f.IndexFaker + 1)
                .RuleFor(b => b.Title, f => f.Lorem.Sentence(5))
                .RuleFor(b => b.Description, f => f.Lorem.Paragraphs(3))
                .RuleFor(b => b.BlogImage, f => f.Image.PicsumUrl())
                .RuleFor(b => b.CreatedDate, f => f.Date.Recent(30))
                // Foreign Key eşleşmesi:
                .RuleFor(b => b.AdminId, f => f.PickRandom(admins).Id);

            return faker.Generate(count);
        }

        public static List<Comments> GenerateComments(int count, List<Members> members)
        {
            var faker = new Faker<Comments>("tr")
                .RuleFor(c => c.Id, f => f.IndexFaker + 1)
                .RuleFor(c => c.Name, f => f.Name.FullName())
                .RuleFor(c => c.Email, f => f.Internet.Email())
                .RuleFor(c => c.CommentSubject, f => f.Lorem.Sentence(3))
                .RuleFor(c => c.CommentText, f => f.Lorem.Text())
                .RuleFor(c => c.CreatedDate, f => f.Date.Recent(10))
                // Foreign Key eşleşmesi:
                .RuleFor(c => c.MemberId, f => f.PickRandom(members).Id);

            return faker.Generate(count);
        }

        public static List<Communication> GenerateCommunications(int count)
        {
            var faker = new Faker<Communication>("tr")
                .RuleFor(c => c.Id, f => f.IndexFaker + 1)
                .RuleFor(c => c.Name, f => f.Name.FullName())
                .RuleFor(c => c.Email, f => f.Internet.Email())
                .RuleFor(c => c.Subject, f => f.Lorem.Sentence(2))
                .RuleFor(c => c.Message, f => f.Lorem.Paragraph())
                .RuleFor(c => c.CreatedDate, f => f.Date.Recent(5));

            return faker.Generate(count);
        }
    }
}