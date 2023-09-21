using Microsoft.AspNetCore.Mvc;

namespace MeetingRoomSystem.Controllers
{
    public class UserAuthenticationController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
