using Microsoft.AspNetCore.Identity;

namespace SellJam.Data
{
    public class AccountIdentity : IdentityUser
    {
        public string? RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
    }
}
