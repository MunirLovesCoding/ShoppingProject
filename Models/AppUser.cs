using Microsoft.AspNetCore.Identity;

namespace ShopingECart.Models
{
    public class AppUser : IdentityUser
    {
        public string Occupation { get; set; }
    }
}
