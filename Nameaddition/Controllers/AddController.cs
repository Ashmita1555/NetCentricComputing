using Microsoft.AspNetCore.Mvc;

namespace Nameaddition.Controllers
{
    public class AddController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
