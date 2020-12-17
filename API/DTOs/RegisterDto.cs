using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required] // validation - user must enter username
        public string Username { get;set; }
        [Required] // Validation - user must enter password
        public string Password { get; set; }

    }
}