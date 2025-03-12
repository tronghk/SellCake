using System.ComponentModel.DataAnnotations;

namespace SellJam.Model
{
    public class SignInModel
    {
        [Required]
        public string Email { get; set; } = null!;
        [Required]
        public string Password { get; set; } = null!;
    }
}
