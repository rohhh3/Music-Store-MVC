using Microsoft.AspNetCore.Mvc;

namespace MusicStore.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Accessories(){ return View(); }
        public IActionResult Drums(){       return View(); }
        public IActionResult GuitBass(){    return View(); }
        public IActionResult Keys(){        return View(); }
        public IActionResult Microphones(){ return View(); }
        public IActionResult Software(){    return View(); }
        public IActionResult Studio(){      return View(); }
    }
}
