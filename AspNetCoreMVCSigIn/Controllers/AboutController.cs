using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVCSigIn.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
