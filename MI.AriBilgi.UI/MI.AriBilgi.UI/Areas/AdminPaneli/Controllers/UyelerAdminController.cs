using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MI.AriBilgi.BLL;
using MI.AriBilgi.DLL;
namespace MI.AriBilgi.UI.Areas.AdminPaneli.Controllers
{
    public class UyelerAdminController : Controller
    {
        UyelerManager uyelerManager = new UyelerManager();
        // GET: AdminPaneli/UyelerAdmin
        public ActionResult UyelerAdminIndex()
        {
            return View(uyelerManager.UyelerList());
        }
        #region Create Uyeler

        public ActionResult CreateUyeler()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateUyeler(Uyeler uyeler)
        {

            string message = uyelerManager.CreateUyeler(uyeler);
            ViewBag.ShowMessage = "<hr />" + message;

            return View();
        }
        #endregion

        public ActionResult UyeEdit(int id)
        {
            var showUye = uyelerManager.FindUye(id);
            ViewBag.Icerik = showUye.UyeAdi;
            return View(showUye);
        }

        [HttpPost]
        public ActionResult UyeEdit(Uyeler uyeGuncelle)
        {
           
            var guncelle = uyelerManager.UpdateUye(uyeGuncelle);
            ViewBag.updateMessage = guncelle;
            return RedirectToAction("UyelerAdminIndex");
        }

        public ActionResult UyeDelete(int Id)
        {
            var getUye = uyelerManager.FindUye(Id);
            return View(getUye);
        }

        [HttpPost, ActionName("UyeDelete")]
        public ActionResult UyeSil(Uyeler uyeler)
        {
            var getUye = uyelerManager.DeleteUye(uyeler.Id);
            ViewBag.silMessage = getUye;
            return RedirectToAction("UyelerAdminIndex");
        }
    }
}