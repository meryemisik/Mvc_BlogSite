using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MI.AriBilgi.BLL;
using MI.AriBilgi.DLL;
namespace MI.AriBilgi.UI.Areas.AdminPaneli.Controllers
{
    public class ProjectAdminController : Controller
    {
        ProjectManager projectManager = new ProjectManager();
        
        // GET: AdminPaneli/ProjectAdmin
        public ActionResult ProjectAdminIndex()
        {
            return View(projectManager.ProjectList());
        }

        #region Create Project

        public ActionResult CreateProject()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateProject(Project project)
        {
            string message = projectManager.CreateProject(project);
            ViewBag.ShowMessage = "<hr />" + message;
            return View();
        }

        #endregion

        public ActionResult ProjectEdit(int id)
        {
            var showArticle = projectManager.FindProject(id);
            ViewBag.Icerik = showArticle.Title;
            return View(showArticle);
        }

        [HttpPost]
        public ActionResult ProjectEdit(Project projectGuncelle)
        {
            
            var guncelle = projectManager.UpdateProject(projectGuncelle);
            ViewBag.updateMessage = guncelle;
            return RedirectToAction("ProjectAdminIndex");
        }

        public ActionResult ProjectDelete(int Id)
        {
            var getProject = projectManager.FindProject(Id);
            return View(getProject);
        }

        [HttpPost, ActionName("ProjectDelete")]
        public ActionResult ProjectSil(Project project)
        {
            var getCategory = projectManager.DeleteProject(project.Id);
            ViewBag.silMessage = getCategory;
            return RedirectToAction("ProjectAdminIndex");
        }

    }
}