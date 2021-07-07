using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MI.AriBilgi.BLL;
using MI.AriBilgi.DLL;
namespace MI.AriBilgi.UI.Areas.AdminPaneli.Controllers
{
    public class CategoriesAdminController : Controller
    {
        CategoryManager categoryManager = new CategoryManager();
        // GET: AdminPaneli/CategoriesAdmin
        public ActionResult CategoriesAdminIndex()
        {
            var list = categoryManager.CategoryList();

            return View(list);
        }

        #region Create Category
        public ActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateCategory(Categories categories)
        {
            string message = categoryManager.CreateCategory(categories);
            ViewBag.ShowMessage = "<hr />" + message;
            return View();
        }

        #endregion

        public ActionResult CategoryEdit(int id)
        {
            var showArticle = categoryManager.FindCategory(id);
            ViewBag.Icerik = showArticle.CategoryName;
            return View(showArticle);
        }


        [HttpPost]
        public ActionResult CategoryEdit(Categories categoryGuncelle)
        {
            
            var guncelle = categoryManager.UpdateCategory(categoryGuncelle);
            ViewBag.updateMessage = guncelle;
            return RedirectToAction("CategoriesAdminIndex");
        }

        public ActionResult CategoryDelete(int Id)
        {
            var getCategory = categoryManager.FindCategory(Id);
            return View(getCategory);
        }

        [HttpPost, ActionName("CategoryDelete")]
        public ActionResult CategorySil(Categories categories)
        {
            var getCategory= categoryManager.DeleteCategory(categories.Id);
            ViewBag.silMessage = getCategory;
            return RedirectToAction("CategoriesAdminIndex");
        }


    }
}