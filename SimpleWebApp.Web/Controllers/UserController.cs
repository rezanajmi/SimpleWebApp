using Microsoft.AspNetCore.Mvc;
using SimpleWebApp.Application.Interfaces;
using SimpleWebApp.Core.Entities;
using SimpleWebApp.Web.Controllers.Base;

namespace SimpleWebApp.Web.Controllers
{
    public class UserController : BaseController
    {
        private readonly IUserService userService;
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        public IActionResult Index()
        {
            return View(userService.GetAll());
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(User user)
        {
            userService.Add(user);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(userService.Get(id));
        }

        [HttpPost]
        public IActionResult Update(User user)
        {
            userService.Update(user);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            userService.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
