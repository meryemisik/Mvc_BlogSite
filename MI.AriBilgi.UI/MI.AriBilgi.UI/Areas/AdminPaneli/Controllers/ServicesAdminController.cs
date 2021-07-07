using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MI.AriBilgi.BLL;
using MI.AriBilgi.DLL;
namespace MI.AriBilgi.UI.Areas.AdminPaneli.Controllers
{
    public class ServicesAdminController : Controller
    {
        ServicesManager servicesManager = new ServicesManager();
        // GET: AdminPaneli/ServicesAdmin
        public ActionResult ServicesAdminIndex()
        {
            return View(servicesManager.ServicesList());
        }
        #region Create Services

        public ActionResult CreateService()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateService(Service service)
        {
            string message = servicesManager.CreateServices(service);
            ViewBag.ShowMessage =  message;
            return View();
        }
        #endregion

        public ActionResult ServiceEdit(int id)
        {
            var showService = servicesManager.FindServices(id);
            ViewBag.Icerik = showService.ServiceAdi;
            return View(showService);
        }

        [HttpPost]
        public ActionResult ServiceEdit(Service serviceGuncelle)
        {
            
            var guncelle = servicesManager.UpdateServices(serviceGuncelle);
            ViewBag.updateMessage = guncelle;
            return RedirectToAction("ServicesAdminIndex");
        }

        public ActionResult ServiceDelete(int Id)
        {
            var getService = servicesManager.FindServices(Id);
            return View(getService);
        }

        [HttpPost, ActionName("ServiceDelete")]
        public ActionResult ServiceSil(Service service)
        {
            var getService = servicesManager.DeleteService(service.ServiceId);
            ViewBag.silMessage = getService;
            //return RedirectToAction("ServicesAdminIndex");
            return View();
        }


        //public ActionResult UyeDelete(int Id)
        //{
        //    var getUye = uyelerManager.FindUye(Id);
        //    return View(getUye);
        //}

        //[HttpPost, ActionName("UyeDelete")]
        //public ActionResult UyeSil(Uyeler uyeler)
        //{
        //    var getUye = uyelerManager.DeleteUye(uyeler.Id);
        //    ViewBag.silMessage = getUye;
        //    return RedirectToAction("UyelerAdminIndex");
        //}


    }
}