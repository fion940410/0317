using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eSale.Controllers
{
    public class OrderController : Controller
    {
        //
        // GET: /Order/

        /// <summary>
        /// 訂單管理系統首頁
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            //Models.OrderService orderService = new Models.OrderService();
            //var order = orderService.GetOrderById("111");
            //ViewBag.CustId = order.Custld;

            ViewBag.test = "test";
            return View();
        }
        public ActionResult Index2(string id)
        {
            ViewBag.id = id;
            return View();
        }
        /// <summary>
        /// 新增訂單的畫面
        /// </summary>
        /// <returns></returns>

        public ActionResult Insertorder()
        {
            Models.Order order = new Models.Order();
            order.CustName = "叡揚資訊";
            return View();
        }

        /// <summary>
        /// 新稱訂單存檔的action
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        [HttpPost()]
        public ActionResult Insertorder(Models.Order order)
        {
            ViewBag.Desc1 = "我是viewBag";
            ViewData["desc2"] = "我是viewData";
            TempData["Desc3"] = "我是tempdata";
            
            return RedirectToAction("index");
        }
         [HttpGet()]
        public JsonResult TestJson()
        {
            //var result = new Models.Order();
            //result.Custld = "GSS";
            //result.CustName = "叡揚";

            var result = new Models.Order() { Custld = "GSS", CustName = "叡揚資訊" };
            return this.Json(result, JsonRequestBehavior.AllowGet);

        }
	}
}