using Microsoft.AspNetCore.Mvc;

namespace HelloMvc
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public IActionResult Index() => View();

        [HttpGet("/Data")]
        public IActionResult Data() => View();
    }
}