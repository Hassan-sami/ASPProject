using Booking.customValidate;
using Booking.Models.Data;
using Booking.viewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Text;
using System.Text.Encodings.Web;

namespace Booking.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _manager;
        private readonly SignInManager<User> _signInManager;
        //private readonly IEmailConfirmationSender _emailConfirmationSender;
        //private readonly IEmailSender _emailSender;
        

        public AccountController(UserManager<User> manager, SignInManager<User> signInManager) {
            this._manager = manager;
            this._signInManager = signInManager;
            
            
            
        }
        [HttpGet]
        public IActionResult Register()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel userView)
        {
            if (ModelState.IsValid) {
                User user = new User();
                user.Email = userView.Email;
                user.UserName = userView.UserName;
                user.PasswordHash = userView.Password;
                user.FirstName = userView.FirstName;
                user.LastName = userView.LastName;
               
                IdentityResult result = await _manager.CreateAsync(user, userView.Password);
                
                
                
                if (result.Succeeded)
                {
                    //Send Confirmation to Email
                    //var token = await _manager.GenerateEmailConfirmationTokenAsync(user);
                    //var code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(token));

                    //var confirmationLink = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, token = code }
                    //, Request.Scheme);

                    
                    //await _emailSender.SendEmailAsync(userView.Email, "Confirm your email",
                    //    $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(confirmationLink)}'>clicking here</a>.");

                    
                    await _manager.AddToRoleAsync(user, "client");
                    


                    await _signInManager.SignInAsync(user, isPersistent: false);

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

            return View(userView);
        }

        //[HttpGet]
        //public async Task<IActionResult> ConfirmEmail(string userId, string code)
        //{

        //    var user = await _manager.FindByIdAsync(userId);
           
        //    var decodedCode = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code));
        //    var result = await _manager.ConfirmEmailAsync(user, decodedCode);

        //    if (result.Succeeded)
        //    {
        //        // Email confirmed successfully
        //        return RedirectToAction("Index", "Home");
        //    }
        //    else
        //    {
        //        return RedirectToAction("Register", "Account");
        //    }
        //}



        [HttpGet]
        public IActionResult LogIn()
        {

            return View("SignIn");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogIn(SignInViewModel userView)
        {
            if (ModelState.IsValid)
            {
               User user =  await _manager.FindByEmailAsync(userView.Email);
                
                if (user != null)
                {
                    bool match = await _manager.CheckPasswordAsync(user, userView.Password);
                    if (match == true) 
                    {
                        await _signInManager.SignInAsync(user,userView.RememberMe);
                        return RedirectToAction("Index", "Home");
                    }
                }
                ModelState.AddModelError("", " Email or passowrd wrong try again");

            }

            return View("SignIn",userView);
        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }


        public async Task<IActionResult> UserInfo()
        {
            User user = await _manager.FindByNameAsync(User.Identity.Name);
            return View(user);
        }

        public IActionResult ChangePassword()
        {
            if (User.Identity.IsAuthenticated)
            {
                ChangePasswordViewModel model = new ChangePasswordViewModel();
                return View(model);
            }

            return RedirectToAction("LogIn", "Account");
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
         {
            if(ModelState.IsValid)
            {
                User user =  await _manager.FindByNameAsync(User.Identity.Name);
                
                 var result = await  _manager.ChangePasswordAsync(user, model.OldPassword, model.ConfirmPassword);
                if (result.Succeeded)
                {
                    TempData["Success"] = "password changed successfully";
                    return RedirectToAction("ChangePassword");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View(model);
                }
            }
            else
            {
                return View(model);
            }
            

        }

    }

}
