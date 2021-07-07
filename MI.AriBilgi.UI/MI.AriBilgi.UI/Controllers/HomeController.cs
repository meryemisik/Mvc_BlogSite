using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MI.AriBilgi.UI.Models;
namespace MI.AriBilgi.UI.Controllers
{
    public class HomeController : Controller
    {
        BlogSiteDBEntities db = new BlogSiteDBEntities();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult Service()
        {
            var data = db.Service.ToList();
            return PartialView(data);
        }
        public PartialViewResult Hakkimda()
        {
            var data = db.hakkinda.ToList();
            return PartialView(data);
        }
      

    }
}