using Blog.Application.Context;
using Blog.Application.Localizations;
using Blog.Application.Models;
using EFIndentityDemo.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Blog.Application.Extensions
{
    public static class StartUpExtensions
    {



        public static void AddIdentityWithExt(this IServiceCollection services)
        {
            services.Configure<DataProtectionTokenProviderOptions>(opt =>
            {
                opt.TokenLifespan = TimeSpan.FromHours(2);//token yasamini 2 saat olarak belirledik
            });

            //sisteme identy ekleme kismi
            services.AddIdentity<AppUser, AppRole>(options =>
            {
                options.User.RequireUniqueEmail = true;
                options.Password.RequiredLength = 6;

                options.Password.RequireNonAlphanumeric = false;//* ? gibini karakterleri  kullanma zorunlulugunu kaldirdik
                options.Password.RequireUppercase = false;//buyuk harf kullanma zorunlulugunu kaldirdik
                options.Password.RequireDigit = false;//sayi kullanma zorunlulugunu kaldirdik

                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(3);
                options.Lockout.MaxFailedAccessAttempts = 3;
            }


            ).AddUserValidator<UserValidator>()
            .AddPasswordValidator<PasswordValidator>()
            .AddEntityFrameworkStores<BlogDbContext>()
            .AddErrorDescriber<LocalizationIdentityErrorDescriber>()
            .AddDefaultTokenProviders().
            AddEntityFrameworkStores<BlogDbContext>();
        }
    }
}
