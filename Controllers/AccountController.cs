using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using AuthApp.Models;
using ProektTRPO.ViewModels;
using ProektTRPO.Models;
using System;
using System.Linq;

namespace ProektTRPO.Controllers
{
    public class AccountController : Controller
    {
        private UserContext db;
        private bool flag=false;
        public AccountController(UserContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            if (User.Identity.Name!=null)
            {
                User user1 = db.Users.FirstOrDefault(u => u.Email == User.Identity.Name);
                ICollection<Key> keys = new HashSet<Key>();
                keys = db.Keys.Where(u => u.UserId == user1.Id).ToList();
                if (keys != null)
                {
                    return View(keys);
                }
                else
                {
                    return View();
                }
            }
            else
            {
                return View();

            }
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(KeysModel model)
        {
            if (model != null)
            {
                User user1 = db.Users.FirstOrDefault(u => u.Email == User.Identity.Name);
                Key key1 = new Key { Keys = model.Keys, EncryptedData = model.EncryptedData, User =user1 };
                db.Keys.Add(key1);
                db.SaveChanges();
            }
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Login()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                User user1 = new User();
                user1 = await db.Users.FirstOrDefaultAsync(u => u.Email == model.Email && u.Password == model.Password);
                if (user1 != null)
                {
                    await Authenticate(model.Email,Convert.ToString(user1.Id)); // аутентификация
                    return RedirectToAction("Index");
                    
                }
                ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
            return View(model);
        }
     
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                User user1 = new User();

                user1 = await db.Users.FirstOrDefaultAsync(u => u.Email == model.Email);
                if (user1 == null)
                {

                    User user2 = new User();

                    // добавляем пользователя в бд
                    user2 = new User { Email = model.Email, Password = model.Password };
                    db.Users.Add(user2);

                    db.SaveChanges();

                    await Authenticate(model.Email,Convert.ToString(user2.Id)); // аутентификация

                    return RedirectToAction("Index");
                }
                else
                    ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
            return View(model);
        }

        private async Task Authenticate(string userName,string ID)
        {
            flag = true;
            // создаем один claim
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, ID)
            };
          
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

        public async Task<IActionResult> Logout()
        {
            flag = false;
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
    }
}

