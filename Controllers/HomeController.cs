using Microsoft.AspNetCore.Mvc;
using HikingInvites.Models;
namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(UserResponse userResponse)
        {
            Repository.AddResponse(userResponse);
            return View("Thanks", userResponse);
        }

    }
}