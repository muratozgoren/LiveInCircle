using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using LiveInCircle.BLL.Abstract;
using LiveInCircle.Model.Entities;
using LiveInCircle.Model.Enums;
using LiveInCircle.UI.MVC.Helper;
using LiveInCircle.UI.MVC.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace LiveInCircle.UI.MVC.Controllers
{
    public class AccountController : Controller
    {
        IUserBLL userBLL;
        public AccountController(IUserBLL user)
        {
            userBLL = user;
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(UserVM userVM)
        {
            try
            {
                User user = new User();
                user.ID = userVM.UserID;
                user.FirstName = userVM.FirstName;
                user.LastName = userVM.LastName;
                user.Email = userVM.Email;
                user.Password = userVM.Password;
                user.Address = userVM.Address;
                userBLL.Insert(user);
                bool result = MailHelper.SendActivationCode(user.FirstName, user.Email, user.ActivationCode);
                if (result)
                {

                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    ViewBag.Message = "Aktivasyon maili gönderilemedi bilgilerinizi kontrol edin";
                    return View();
                }
            }
            catch (Exception)
            {

                ViewBag.Message = "Bir aksilik oldu";
                return View();
            }
                      
        }
        //http://localhost:57356/Account/ActivationUser/{1}

        public IActionResult ActivationUser(Guid id)
        {
            User newUser = userBLL.GetUserByActivationCode(id);
            if (newUser!=null)
            {
                newUser.IsActive = true;
                userBLL.Update(newUser);
                return RedirectToAction("Login");
            }
            else
            {
                ViewBag.Message = "Aktif edilecek bir kullanıcı bulunmamaktadır";
            }
            return View();
        }

        public IActionResult Login()
        { 
            return View(); 
        }
        [HttpPost]
        public IActionResult Login(LoginVM login)
        {
          User loginUser= userBLL.GetUserByLoginData(login.Email, login.Password);
            if (loginUser!=null)
            {
                List<Claim> claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name,loginUser.Email),
                    new Claim(ClaimTypes.Role,loginUser.Role.ToString())
                };

                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);

                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

                if (loginUser.Role==UserRole.Standart)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return RedirectToAction("Index", "Management", new { area = "Admin" });
                }
            }
            else
            {
                ViewBag.Message = "Kullanıcı bilgilerinizi kontrol edin";
            }
            return View();
        }
    }
}
