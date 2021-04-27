using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return Content("<h1>Hello World</h1>", "text/html");
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public IActionResult Welcome(string name, int ID = 1)
        {
            return Content(HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}"));
        }

        public IActionResult Goodbye()
        {
            return Content("Goodbye");
        }
    }
}