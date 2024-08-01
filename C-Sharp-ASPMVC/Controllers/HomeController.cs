using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace C_Sharp_ASPMVC.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
        
        public String IndexA()
        {
            return "進站時間2" + DateTime.Now.ToString();
        }
        public String Index()
        {
            return "進站時間" + DateTime.Now.ToString();
        }
    }
}
