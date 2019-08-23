using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab20CoffeeShopPt3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab20CoffeeShopPt3.Controllers
{
    public class DatabaseController : Controller
    {
        private readonly CoffeeShopDbContext _context;

        public DatabaseController(CoffeeShopDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Users> userList = _context.Users.ToList();
            
            return View(userList);
            
        }

        public IActionResult RegisterUser()
        {
            _context.SaveChanges();
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Shop()
        {
            return View();
        }

        public IActionResult MakeNewUser()
        {
            List<Users> userList = _context.Users.ToList();
            return View(userList);
        }
        [HttpPost]
        public IActionResult MakeNewUser(Users newUser)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(newUser);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}