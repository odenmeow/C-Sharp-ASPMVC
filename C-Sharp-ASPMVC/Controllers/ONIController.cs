using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace C_Sharp_ASPMVC.Controllers
{
    public class ONIController : Controller
    {
        // GET: ONI
        //public ActionResult Index()
        //{
        //    return View();
        //}

        // 另外寫
        public String Index()
        {
            return "故意創建兩個控制器都有 Index，看看進去localhost:50483會怎樣";
        }
    }
}