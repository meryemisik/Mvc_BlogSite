using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MI.AriBilgi.BLL;
using MI.AriBilgi.DLL;
namespace MI.AriBilgi.UI.Areas.AdminPaneli.Controllers
{
    public class ArticleAdminController : Controller
    {
        ArticleManager articleManager = new ArticleManager();
        // GET: AdminPaneli/ArticleAdmin
        public ActionResult ArticleAdminIndex()
        {
            var list = articleManager.ArticleList();

            return View(list);
        }
        #region Create Article
        public ActionResult CreateArticle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateArticle(Articles article)
        {
           string message= articleManager.CreateArticle(article);
            ViewBag.ShowMessage = message;
            return RedirectToAction("ArticleAdminIndex");
        }
        #endregion
        
        public ActionResult ArticleEdit(int id)
        {
            var showArticle = articleManager.FindArticle(id);
            ViewBag.Icerik = showArticle.Content; 
            return View(showArticle);
        }

        [HttpPost]
        public ActionResult ArticleEdit(Articles articleGuncelle, string articleContent)
        {
            articleGuncelle.Content = articleContent;
            var guncelle = articleManager.UpdateArticle(articleGuncelle);
            ViewBag.updateMessage= guncelle;
            return RedirectToAction("ArticleAdminIndex");
        }

        public ActionResult ArticleDelete(int Id)
        {
            var getArticle = articleManager.FindArticle(Id);
            return View(getArticle);
        }

        [HttpPost,ActionName("ArticleDelete")]
        public ActionResult ArticleSil(Articles articles)
        {
            var getArticle = articleManager.DeleteArticle(articles.Id);
            ViewBag.silMessage = getArticle;
            return RedirectToAction("ArticleAdminIndex");
        }

    }
}