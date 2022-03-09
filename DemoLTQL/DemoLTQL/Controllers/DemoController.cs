using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoLTQL.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            ViewBag.Message = "";
            return View();
        }
        [HttpPost]
        public ActionResult Index(string MaSinhVien, string TenSinhVien)
        {
            ViewBag.Message = MaSinhVien;
            ViewBag.Message = TenSinhVien;
            return View();
        }
    }
}
