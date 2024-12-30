using Microsoft.AspNetCore.Mvc;

namespace mrbatri.Controllers;

public class UserController : Controller
{
    // 
    // GET: /User/
    public IActionResult Index()
    {
        return View();
    }
}