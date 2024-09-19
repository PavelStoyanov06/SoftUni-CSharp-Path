namespace CinemaApp.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using System.Diagnostics;

    using CinemaApp.Web.ViewModels;

    public class HomeController : Controller
    {
        public HomeController()
        {
            
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "Home Page";
            ViewData["Message"] = "Welcome to the Cinema Web App!";

            return View();
        }
    }
}
