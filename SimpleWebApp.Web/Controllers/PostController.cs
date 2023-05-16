using Microsoft.AspNetCore.Mvc;
using SimpleWebApp.Application.Interfaces;
using SimpleWebApp.Core.Entities;
using SimpleWebApp.Web.Controllers.Base;

namespace SimpleWebApp.Web.Controllers
{
    public class PostController : BaseController
    {
        private readonly IPostService postService;
        public PostController(IPostService postService)
        {
            this.postService = postService;
        }

        public IActionResult Index()
        {
            return View(postService.GetAll());
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Post post)
        {
            postService.Add(post);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(postService.Get(id));
        }

        [HttpPost]
        public IActionResult Update(Post post)
        {
            postService.Update(post);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            postService.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
