using System.ComponentModel.DataAnnotations;

namespace FullStack.net.PluralSight.Core.ViewModel
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
