using Microsoft.AspNetCore.Identity;

namespace LearnIdentity.Data
{
    public class ApplicationUser :IdentityUser
    {
        public string? Name { get; set; }
        public string? ProfilePicture { get; set; }
    }
}
