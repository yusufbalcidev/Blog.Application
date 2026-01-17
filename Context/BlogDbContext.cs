using System.Reflection;
using Blog.Application.DataGenerator;
using Blog.Application.Models.Entities;
using Blog.Application.Models.EntityTypeConfigurations;
using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Blog.Application.Context
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {
        }
        public BlogDbContext()
        {
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Admins> Admins { get; set; }
        public DbSet<Blogs> Blogs { get; set; }
        public DbSet<Communication> Communications { get; set; }
        public DbSet<Members> Members { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("blg");
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            // 1. Bağımsız Veriler
            var admins = BlogDataGenerator.GenerateAdmins(3);
            var members = BlogDataGenerator.GenerateMembers(10);
            var communications = BlogDataGenerator.GenerateCommunications(5);

            // 2. Bağımlı Veriler (Foreign Key atamaları generator içinde yapıldı)
            var blogs = BlogDataGenerator.GenerateBlogs(5, admins);
            var comments = BlogDataGenerator.GenerateComments(15, members);

            // 3. Veritabanına Ekleme (HasData navigasyon propertyleri sevmez, sadece Id'leri basar)
            modelBuilder.Entity<Admins>().HasData(admins);
            modelBuilder.Entity<Members>().HasData(members);
            modelBuilder.Entity<Communication>().HasData(communications);

            // Blog ve Comment eklerken navigasyon nesnelerini null yapmalısın yoksa hata alabilirsin
            blogs.ForEach(x => x.Admins = null);
            modelBuilder.Entity<Blogs>().HasData(blogs);

            comments.ForEach(x => x.Members = null);
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
                    options.CommandTimeout(5_000);
                    options.EnableRetryOnFailure(maxRetryCount: 5);
                });

                // Hazırlanan ayarları constructor'a göndererek nesneyi döndürün
                return new BlogDbContext(optionsBuilder.Options);
            }

        }
    }
}
