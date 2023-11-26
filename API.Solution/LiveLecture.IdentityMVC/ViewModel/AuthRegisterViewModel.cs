using LiveLecture.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace LiveLecture.IdentityMVC.ViewModel
{
    public class AuthRegisterViewModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        [MinLength(2)]
        public string UserName { get; set; }
        [Required]
        [MinLength(6)]
        public string Password { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public DateTimeOffset? BirthDate { get; set; }
        [Required]
        public Gender Gender { get; set; }

    }
}
