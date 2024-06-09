using AspNetCoreMVCSigIn.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVCSigIn.Controllers;

public class AccountController : Controller
{
    // private readonly AccountService _accountService;

    // public AccountController(AccountSerivce accountService)
    // {
    //      _accountService = accountService;
    // }

    [Route("/account")]
    public IActionResult Details()
    {
        var viewModel = new AccountDetailsViewModel();
        //viewModel.BasicInfo = _accountService.GetBasicInfo();
        //viewModel.AddressInfo = _accountService.GetAddressInfo();


        return View(viewModel);
    }

    [HttpPost]
    public IActionResult BasicInfo(AccountDetailsViewModel viewModel)
    {
        //_accountService.SaveBasicInfo(viewModel.BasicInfo)
        return RedirectToAction("Details", viewModel);
    }


    [HttpPost]
    public IActionResult AddressInfo(AccountDetailsViewModel viewModel)
    {
        //_accountService.SaveAddressInfo(viewModel.BasicInfo)

        return RedirectToAction("Details", viewModel);
    }
}
