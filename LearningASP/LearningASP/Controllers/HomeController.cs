using LearningASP.ActionFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearningASP.Controllers
{
    [MyLogActionFilter]
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return RedirectToAction("GetAllCustomers", "Customer");
        }

        [ActionName("CurrentTime")]
        public string GetCurrentTime()
        {
            return TimeString();
        }

        [NonAction]
        public string TimeString()
        {
            return "Time is " + DateTime.Now.ToString("T");
        }

        [HttpGet]
        public ActionResult Search(string name)
        {
            // Access by route /Home/Search?name=123
            var input = Server.HtmlEncode(name);
            return Content(input);
        }
        
        public ActionResult Search()
        {
            var input = "Another Search action";
            return Content(input);
        }

        public ActionResult DemoView()
        {
            return View();
        }
    }
}