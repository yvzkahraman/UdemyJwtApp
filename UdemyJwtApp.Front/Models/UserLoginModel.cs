using System.ComponentModel.DataAnnotations;

namespace UdemyJwtApp.Front.Models
{
    public class UserLoginModel
    {
        [Required(ErrorMessage="Username gereklidir")]
        public string Username { get; set; } = null!;

        [Required(ErrorMessage = "Password gereklidir")]
        public string Password { get; set; } = null!;
    }
}
