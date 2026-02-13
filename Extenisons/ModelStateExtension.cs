using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Blog.Application.Extensions
{
    public static class ModelStateExtension
    {
        public static void AddModelErrorList(this ModelStateDictionary modelState, List<string> errors)
        {
            foreach (var x in errors)
            {
                modelState.AddModelError(string.Empty, x);
            }
        }

        public static void AddModelErrorList(this ModelStateDictionary modelState, IEnumerable<IdentityError> errors)
        {
            foreach (var x in errors)
            {
                modelState.AddModelError(string.Empty, x.Description);
            }
        }
    }
}
