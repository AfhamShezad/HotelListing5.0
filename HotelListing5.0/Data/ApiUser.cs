using Microsoft.AspNetCore.Identity;

namespace HotelListing5._0.Data
{
    public class ApiUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
