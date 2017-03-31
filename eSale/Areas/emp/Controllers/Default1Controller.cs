using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eSale.Areas.emp.Controllers
{
    public class Default1Controller : Controller
    {
        //
        // GET: /emp/Default1/
        public ActionResult Index()
        {
            ViewBag.desc = "hello emp";
            return View();
        }
	}
}