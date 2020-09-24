using Microsoft.AspNetCore.Identity;

namespace DataLayer.Models
{
    public class Employee : IdentityUser
    {
        public string Surname { get; set; }
        public string FirstName { get; set; }
    }
}
