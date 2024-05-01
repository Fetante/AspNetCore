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

    [Route("/signin")] // Använd routen /signup till vyn Auth/SignUp
    [HttpGet]
    public IActionResult SignIn()
    {
        var viewModel = new SignInViewModel();
        return View(viewModel);
    }

    [Route("/signin")]
    [HttpPost]
    public IActionResult SignIn(SignInViewModel viewModel)
    {
        if (!ModelState.IsValid)         
            return View(viewModel);

        // var result = _authService.SignIn(viewModel.Form);
        // if (result)
        //    return RedirectToAction("Account", "Index");


        viewModel.ErrorMessage = "Email or password invalid";
        return View(viewModel);




    }
}
