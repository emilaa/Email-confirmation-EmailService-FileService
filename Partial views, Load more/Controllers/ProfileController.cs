using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Partial_views__Load_more.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Partial_views__Load_more.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Profile()
        {
            var user = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);

            return View(user);
        }
    }
}
