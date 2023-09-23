using MeetingRoomSystem.Models.DTO;
using MeetingRoomSystem.Repositories.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace MeetingRoomSystem.Controllers
{
    public class UserAuthenticationController : Controller
    {
        private readonly IUserAuthenticationService _service;

        public UserAuthenticationController(IUserAuthenticationService service)
        {
            _service = service;
        }

        public IActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Registration(RegistrationModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            model.Role = "user";
            var result = await _service.RegistrationAsync(model);
            //TempData["msg"] = result.Message;
            return RedirectToAction(nameof(Registration));
        }


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var result = await _service.LoginAsync(model);
            if (result.StatusCode == 1)
            {
                return RedirectToAction("Display", "Dashboard");
            }
            else
            {
                //TempData["msg"] = result.Message;
                return RedirectToAction(nameof(Login));
            }
        }
        [Authorize]
        public async Task<IActionResult> Logout()
        {
           await  _service.LogoutAsyn();
            return RedirectToAction(nameof(Login));
        }

        //public async Task<IActionResult> Reg()
        //{
        //    var model = new RegistrationModel
        //    {
        //        Username = "admin123456",
        //        Name = "admin",
        //        Email = "admin123456@gmail.com",
        //        Password = "Adm!N@123456"
        //    };
        //    model.Role = "admin";
        //    var result = await _service.RegistrationAsync(model);
        //    return Ok(result);
        //}
    }
}
