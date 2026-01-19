using System;
using System.Collections.Generic;
using System.Linq;
using Bogus;
using EFIndentityDemo.Models;
using Microsoft.AspNetCore.Identity;
using Blog.Application.Models.Entities;

namespace Blog.Application.DataGenerator
{
    public static class BlogDataGenerator
    {
        public static List<Admins> GenerateAdmins(int count)
        {
            int adminId = 1;

            return new Faker<Admins>("tr")
                .RuleFor(a => a.Id, _ => adminId++)
                .RuleFor(a => a.UserName, f => f.Internet.UserName())
                .RuleFor(a => a.Password, f => f.Internet.Password(10))
                .RuleFor(a => a.CreatedDate, f => f.Date.Recent(180))
                .Generate(count);
        }

        public static List<AppUser> GenerateMembers(int count) => GenerateUsers(count);

        private static List<AppUser> GenerateUsers(int count)
        {
            var hasher = new PasswordHasher<AppUser>();

            return new Faker<AppUser>("tr")
                .RuleFor(u => u.Id, _ => Guid.NewGuid().ToString())
                .RuleFor(u => u.UserName, f => f.Internet.UserName())
                .RuleFor(u => u.NormalizedUserName, (f, u) => u.UserName!.ToUpperInvariant())
                .RuleFor(u => u.Email, f => f.Internet.Email())
                .RuleFor(u => u.NormalizedEmail, (f, u) => u.Email!.ToUpperInvariant())
                .RuleFor(u => u.EmailConfirmed, _ => true)
                .RuleFor(u => u.SecurityStamp, _ => Guid.NewGuid().ToString())
                .RuleFor(u => u.ConcurrencyStamp, _ => Guid.NewGuid().ToString())
                .RuleFor(u => u.City, f => f.Address.City())
                .RuleFor(u => u.Picture, f => f.Image.PicsumUrl())
                .RuleFor(u => u.BirthDate, f => f.Date.Past(30, DateTime.Now.AddYears(-18)))
                .RuleFor(u => u.Gender, f => f.PickRandom<Gender>())
                .RuleFor(u => u.PhoneNumber, f => f.Phone.PhoneNumber("05#########"))
                .FinishWith((_, u) =>
                {
                    u.PasswordHash = hasher.HashPassword(u, "Password12*");
                })
                .Generate(count);
        }

        public static List<Blogs> GenerateBlogs(int count, List<Admins> admins)
        {
            if (admins == null || !admins.Any()) return new List<Blogs>();

            int blogId = 1;

            return new Faker<Blogs>("tr")
                .RuleFor(b => b.Id, _ => blogId++)
                .RuleFor(b => b.Title, f => f.Lorem.Sentence(5))
                .RuleFor(b => b.Description, f => f.Lorem.Paragraphs(3))
                .RuleFor(b => b.BlogImage, f => f.Image.PicsumUrl())
                .RuleFor(b => b.CreatedDate, f => f.Date.Recent(30))
                .RuleFor(b => b.AdminId, f => f.PickRandom(admins).Id)
                .Generate(count);
        }

        public static List<Comments> GenerateComments(int count, List<AppUser> users, List<Blogs> blogs)
        {
            if (blogs == null || !blogs.Any()) return new List<Comments>();
            users ??= new List<AppUser>();

            int commentId = 1;

            return new Faker<Comments>("tr")
                .RuleFor(c => c.Id, _ => commentId++)
                .RuleFor(c => c.Name, f => f.Name.FullName())
                .RuleFor(c => c.Email, f => f.Internet.Email())
                .RuleFor(c => c.CommentSubject, f => f.Lorem.Sentence(3))
                .RuleFor(c => c.CommentText, f => f.Lorem.Text())
                .RuleFor(c => c.CreatedDate, f => f.Date.Recent(10))
                .RuleFor(c => c.BlogId, f => f.PickRandom(blogs).Id)
                .RuleFor(c => c.AppUserId, f =>
                {
                    if (!users.Any()) return null;
                    return f.Random.Bool(0.6f) ? null : f.PickRandom(users).Id;
                })
                .Generate(count);
        }

        public static List<Communication> GenerateCommunications(int count)
        {
            int commId = 1;

            return new Faker<Communication>("tr")
                .RuleFor(c => c.Id, _ => commId++)
                .RuleFor(c => c.Name, f => f.Name.FullName())
                .RuleFor(c => c.Email, f => f.Internet.Email())
                .RuleFor(c => c.Subject, f => f.Lorem.Sentence(2))
                .RuleFor(c => c.Message, f => f.Lorem.Paragraph())
                .RuleFor(c => c.CreatedDate, f => f.Date.Recent(5))
                .Generate(count);
        }

        public static About GenerateAbout()
        {
            return new Faker<About>("tr")
                .RuleFor(a => a.Id, _ => 1)
                .RuleFor(a => a.Description, f => f.Lorem.Paragraphs(2))
                .RuleFor(a => a.FotoUrl, f => f.Image.PicsumUrl())
                .RuleFor(a => a.CreatedDate, f => f.Date.Recent())
                .Generate();
        }
    }
}
