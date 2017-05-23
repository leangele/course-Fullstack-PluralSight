using System.ComponentModel.DataAnnotations;

namespace FullStack.net.PluralSight.Core.ViewModel
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}