using AspNetCoreMVCSigIn.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVCSigIn.Controllers;

public class AuthController : Controller
{
    [Route("/signup")] // Använd routen /signup till vyn Auth/SignUp
    [HttpGet]
   public IActionResult SignUp ()
    {
        var viewModel = new SignUpViewModel();
        return View(viewModel);
    }

    [Route("/signup")]
    [HttpPost]
    public IActionResult SignUp(SignUpViewModel viewModel)
    {        
        if (!ModelState.IsValid)    // Om formuläret ej är korrekt visa samma sida
            return View(viewModel);

        return RedirectToAction("SignIn", "Auth"); // Redirecta till signin om allt är ok

    }
}
