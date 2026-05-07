using Microsoft.AspNetCore.Mvc;
using MvcBindingApp.Models;

namespace MvcBindingApp.Controllers
{
    public class UserController : Controller
    {
        // 1. This shows the empty form when you first visit the page
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // 2. This catches the data after you click the "Submit" button
        [HttpPost]
        public IActionResult Create(User submittedUser)
        {
            // We take the data you typed in and send it to a "Result" page to show you
            return View("Result", submittedUser);
        }
    }
}