using calculation.Models;
using Microsoft.AspNetCore.Mvc;

namespace calculation.Controllers
{
    public class CalculateController : Controller
    {
        public IActionResult Index()
        {
            return View( new Calculation());
        }
        [HttpPost]
        //get:cal
        public ActionResult Index (Calculation c,string calculate)
        {
           
            switch (calculate)
            {
                case "add":
                 
                    c.result = c.n1 + c.n2;
                    break;

                case "min":
            
                    
                        c.result = c.n1 - c.n2;
                    break;
                    case "mul":
                   
                    
                        c.result = c.n1 * c.n2;
                    break;
                case "div":
                    if(c.n2!=0) {
                        c.result = c.n1 / c.n2;
                    }
                    else
                    {
                        ModelState.AddModelError("n2", "cannot divide by zero");
                        return View(c);
                    }
                    break;
            }
            return View(c);
        }
    }
}
