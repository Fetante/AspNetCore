using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVCSigIn.Controllers;

public class ContactController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
