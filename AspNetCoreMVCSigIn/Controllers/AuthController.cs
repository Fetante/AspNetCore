using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVCSigIn.Controllers;

public class AuthController : Controller
{
    [Route("/signup")] // Använd routen /signup till vyn Auth/SignUp
   public IActionResult SignUp ()
    {
        return View();
    }
}
