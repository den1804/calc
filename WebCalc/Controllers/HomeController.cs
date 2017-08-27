using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebCalc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetEvents()
        {
            using (MyCalcDBEntities db = new MyCalcDBEntities())
            {
                var events = db.Events.ToList();
                return new JsonResult
                {
                    Data = events,
                    JsonRequestBehavior = JsonRequestBehavior.AllowGet
                };
            }
        }
    }
}