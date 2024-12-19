using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace class_06.Controllers
{
    public class HOMEController : Controller
    {
        // GET: HOME
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Layout()
        {
            return View();
        }
        public ActionResult website()
        {
            return View();
        }
        public ActionResult about()
        {
            return View();
        }
    }
}