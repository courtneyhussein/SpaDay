using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //Get //user/add
        //This Action pulls up the Add User form for filling out.
        [HttpGet]
        //[HttpPost]
        //[Route("/User/Add")]//dont think i need this
        public IActionResult Add()
        {
            return View();
        }

     

        
        [Route("/User")]//This is a total guess on my part.
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            if (newUser.Password == verify)
            {
                ViewBag.username = newUser.UserName;
                ViewBag.email = newUser.Email;
                ViewBag.date = newUser.AccountCreationDate;
                return View("Index");
            }
            else
            {
                ViewBag.username = newUser.UserName;
                ViewBag.email = newUser.Email;
                ViewBag.error = "Your passwords did not match. Please re-enter.";
                return View("Add");
            }
            
        }
    }

}

