using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MI.AriBilgi.UI.Models;
namespace MI.AriBilgi.UI.Controllers
{
    public class ArticleController : Controller
    {
        BlogSiteDBEntities db = new BlogSiteDBEntities();
        // GET: Article
        public ActionResult ArticleIndex()
        {
            var makaleGetir = db.Articles.ToList();
            return View(makaleGetir);
        }
        public ActionResult ArticleDetails(int id)
        {
            var MakaleDetay = db.Articles.Where(x => x.Id == id).FirstOrDefault();
            return View(MakaleDetay);
        }
    }
}