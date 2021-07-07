using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MI.AriBilgi.UI.Models;
namespace MI.AriBilgi.UI.Controllers
{
    public class ProjectController : Controller
    {
        BlogSiteDBEntities db = new BlogSiteDBEntities();
        // GET: Project
        public ActionResult ProjectsIndex()
        {
            var data = db.Project.ToList();
            return View(data);
        }
        
    }
}