using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace SellJam.Data
{
    public class ApplicationRole : IdentityRole<string>
    {
        public ApplicationRole()
        {
            Id = Guid.NewGuid().ToString();
        }

        public ApplicationRole(string roleName) : this()
        {
            Name = roleName;
        }

        internal List<Claim> Claims { get; set; }
    }
}
