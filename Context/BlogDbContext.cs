using System.Reflection;
using Blog.Application.DataGenerator;
using Blog.Application.Models.Entities;
using EFIndentityDemo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Blog.Application.Context
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options) { }
        public BlogDbContext() { }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Blogs> Blogs { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Communication> Communications { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("blg");
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            // 1) Bağımsız veriler
            var admins = BlogDataGenerator.GenerateAdmins(3);
            var members = BlogDataGenerator.GenerateMembers(10);
            var communications = BlogDataGenerator.GenerateCommunications(5);
            var about = BlogDataGenerator.GenerateAbout();

            // 2) Bağımlı veriler
            var blogs = BlogDataGenerator.GenerateBlogs(8, admins);
            var comments = BlogDataGenerator.GenerateComments(25, members, blogs);

            // --- HasData: navigation'ları null yap ---
            modelBuilder.Entity<Admins>().HasData(admins);
            modelBuilder.Entity<AppUser>().HasData(members);
            modelBuilder.Entity<Communication>().HasData(communications);
            modelBuilder.Entity<About>().HasData(about);

            blogs.ForEach(b => b.Admins = null);
            modelBuilder.Entity<Blogs>().HasData(blogs);

            comments.ForEach(c =>
            {
                c.Blogs = null;
                c.AppUser = null;
            });
            modelBuilder.Entity<Comments>().HasData(comments);

            base.OnModelCreating(modelBuilder);
        }

        public class DbContextFactory : IDesignTimeDbContextFactory<BlogDbContext>
        {
            public BlogDbContext CreateDbContext(string[] args)
            {
                var connStr = "Server=.\\SQLEXPRESS;Database=BlogDb;Trusted_Connection=True;TrustServerCertificate=True;";
                var optionsBuilder = new DbContextOptionsBuilder<BlogDbContext>();

                optionsBuilder.UseSqlServer(connStr, options =>
                {
                    options.MigrationsHistoryTable("_MigrationsHistoryTable", schema: "blg");
                    options.CommandTimeout(5000);
                    options.EnableRetryOnFailure(maxRetryCount: 5);
                });

                return new BlogDbContext(optionsBuilder.Options);
            }
        }
    }
}
