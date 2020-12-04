using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace DigiTours.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public partial class ApplicationUser
    {
        public enum Account { 'S','G','A' }
    }

    public class ApplicationUser : IdentityUser
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Account AccountType { get; set; }
    }
}
