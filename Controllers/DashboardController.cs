using Microsoft.AspNetCore.Mvc;

namespace MeetingRoomSystem.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Display()
        {
            return View();
        }
    }
}
