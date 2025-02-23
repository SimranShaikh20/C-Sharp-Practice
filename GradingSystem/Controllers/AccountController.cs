using Microsoft.AspNetCore.Mvc;

namespace GradingSystem.Controllers
{
    public class AccountController : Controller
    {
        // GET: /Account/Login
        public IActionResult Login()
        {
            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        public IActionResult Login(string prnNumber, string password)
        {
            // Add your authentication logic here
            if (prnNumber == "12345" && password == "password")
            {
                // Redirect to the home page or dashboard on successful login
                return RedirectToAction("Index", "Home");
            }
            else
            {
                // Show error message for invalid credentials
                ViewBag.ErrorMessage = "Invalid PRN number or password.";
                return View();
            }
        }
    }
}