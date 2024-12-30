using Microsoft.AspNetCore.Mvc;

namespace mrbatri.Controllers;

public class UserPageController : Controller
{
    // 
    // GET: /User/
    public IActionResult Index()
    {
        return View();
    }
}