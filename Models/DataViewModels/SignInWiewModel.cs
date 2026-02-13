using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

namespace Blog.Application.Models.DataViewModels
{
    public class SignInViewModel
    {
        public SignInViewModel()
        {
            
        }
        public SignInViewModel(string email, string password, bool rememberMe)
        {
            RememberMe = rememberMe;
            Email = email;
            Password = password;
        }


        [EmailAddress(ErrorMessage = "Lütfen Geçerli Bir Email Adresi Giriniz.")]
        [Required(ErrorMessage = "Email Alanı Boş Bırakılamaz.")]
        [Display(Name = "Email :")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Şifre Alanı Boş Bırakılamaz.")]
        [Display(Name = "Şifre :")]
        [MinLength(6, ErrorMessage = "Lütfen en az 6 karakter giriniz.")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
