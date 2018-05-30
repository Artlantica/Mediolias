using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearningASP.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return RedirectToAction("GetAllCustomers", "Customer");
        }
        
        [OutputCache(Duration = 20)]
        public string GetCurrentTime()
        {
            // Output will be same in 20s
            // After 20s, output will be change
            return DateTime.Now.ToString("T");
        }
    }
}