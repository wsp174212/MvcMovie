using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
     /*   public IActionResult Index()
        {
            return View();
        }*/

        public IActionResult Welcome(string name, int numTimes  = 1)
        {
            //return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
        //public string Welcome()
        //{
        //    return "this is the welcome action method!";
        //}

    }
}
