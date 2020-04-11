using System.ComponentModel.DataAnnotations;

namespace FirstApp.API.DTOs
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "The password length should be between 4 and 5")]
        public string Password { get; set; }
    }
}