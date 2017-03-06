using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloMVC.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [Route("/hello")]
        [HttpGet]
        public IActionResult Index(string name = "World")
        {
            //string html = "<form method=\"post\" action=\"/hello\">" +
            //    "<input type=\"text\" name=\"name\" />" +
            //    "<input type=\"submit\" value=\"Greet me!\" />" +
            //    "</form>";

            // return Content(html, "text/html");
            return Redirect("/hello/goodbye");
        }

        [Route("/hello")]
        [HttpPost]
        public IActionResult Display(string name = "World")
        {
            return Content(string.Format("<h1>Hello {0}</h1>", name), "text/html");
        }
        
        // Handle requests to /hello/nick (URL segment)
        [Route("/hello/{name}")]
        public IActionResult Index2(string name)
        {
            return Content(string.Format("<h1>Hello {0}</h1>", name), "text/html");
        }

        // GET: /hello/aloha
        [Route("/hello/aloha")]
        public IActionResult Goodbye()
        {
            return Content("Goodbye");
        }
    }
}
