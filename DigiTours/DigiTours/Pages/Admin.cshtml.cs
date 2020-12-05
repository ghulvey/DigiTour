using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DigiTours.Data;
using Microsoft.AspNetCore.Identity;

namespace DigiTours.Pages
{
    public class AdminModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public string UserID { get; set; }
        public string Type { get; set; }
        public string Password { get; set; }
        public void OnGet()
        {
        }
        
        public async Task OnPostAsync()
        {
            if(Password == "Password24$")
            {
                var user = await _userManager.GetUserAsync(User);
                user.AccountType = Type;
            }
        }
    }
}
