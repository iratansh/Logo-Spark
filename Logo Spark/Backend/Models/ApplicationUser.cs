// Models/ApplicationUser.cs
using Microsoft.AspNetCore.Identity;

namespace LogoSpark.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // Add any additional user properties you need
    }
}