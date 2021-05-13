using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloController : Controller
    {
        // 
        // GET: /HelloWorld/
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method ='post'>" +
                "<input type='text' name='name' /><br>" +
                "<input type='submit' value='Greet me!' />" +
                "</form>";

            return Content(html, "text/html");
        }

        // /Hello
        [Route("/Hello")]
        [HttpPost]
        public IActionResult Display(string name = "World")
        {
            string button = "<form method='post' action='/Hello/Redir'>" +
                "<input type='submit' value='Finished' />" +
                "</form>";
            return Content(string.Format("<h1>Hello {0}</h1><br>{1}", name, button), "text/html");
        }

        public IActionResult Redir()
        {
            return Redirect("/Hello/Goodbye");
        }

        // Handle requests to /Hello/NAME (URL segment)
        [Route("/Hello/{name}")]
        public IActionResult Index2(string name)
        {
            string button = "<form method='post' action='/Hello/Redir'>" +
                "<input type='submit' value='Finished' />" +
                "</form>";
            return Content(string.Format("<h1>Hello {0}</h1><br>{1}", name, button), "text/html");
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