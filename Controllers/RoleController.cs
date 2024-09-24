using Booking.Models.Data;
using Booking.viewModel;
using Humanizer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Booking.Controllers
{
    [Authorize(Roles = "admin")]
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<User> _userManager;

        public RoleController(RoleManager<IdentityRole> roleManager,UserManager<User> userManager) 
        {
            this._roleManager = roleManager;
            this._userManager = userManager;
        }

        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateRole(RoleViewModel roleView)
        {
            if (ModelState.IsValid)
            {
                
                    IdentityRole identityRole = new IdentityRole();
                    identityRole.Name = roleView.RoleName.ToLower();
                    IdentityResult identityResult =  await _roleManager.CreateAsync(identityRole);
                    if (identityResult.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        foreach (var error in identityResult.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }
                    }

                
            }
            return View(roleView);
        }

        [HttpGet]
        public IActionResult AddRole()
        {
            UserRoleViewModel userRoleView = new UserRoleViewModel();
            userRoleView.Roles = _roleManager.Roles.Select(x => x.Name).ToList();


            return View(userRoleView);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddRole(UserRoleViewModel userRoleView) 
        {
            User user = await _userManager.FindByEmailAsync(userRoleView.Email);
            IdentityRole role = await _roleManager.FindByNameAsync(userRoleView.RoleName.ToLower());
            if (role == null)
            {
                ModelState.AddModelError("Roles", "select a role");
            }
            if (user == null)
            {
                ModelState.AddModelError("Email", "this Email deos not exist");

            }
            if (ModelState.IsValid)
            {
                
                
                    IdentityResult result = await _userManager.AddToRoleAsync(user, userRoleView.RoleName.ToLower());
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }
                    }
                    
            }
            userRoleView.Roles = _roleManager.Roles.Select(x => x.Name).ToList();
            return View(userRoleView);
        }
    }
}
