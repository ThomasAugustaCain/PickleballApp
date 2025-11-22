using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PickleballApp.Models;

namespace PickleballApp.Controllers;

public class HomeController : Controller
{
    

    public IActionResult Index()
    {
        return View();
    }

    
}
