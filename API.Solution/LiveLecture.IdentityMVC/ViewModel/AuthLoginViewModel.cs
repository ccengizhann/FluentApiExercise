using System.ComponentModel.DataAnnotations;

namespace LiveLecture.IdentityMVC.ViewModel
{
    public class AuthLoginViewModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
