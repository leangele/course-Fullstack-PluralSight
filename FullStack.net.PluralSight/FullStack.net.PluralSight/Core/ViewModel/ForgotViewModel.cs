using System.ComponentModel.DataAnnotations;

namespace FullStack.net.PluralSight.Core.ViewModel
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}