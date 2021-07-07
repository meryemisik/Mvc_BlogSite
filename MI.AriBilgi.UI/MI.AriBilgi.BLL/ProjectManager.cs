using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MI.AriBilgi.DLL;
namespace MI.AriBilgi.BLL
{
       
   public class ProjectManager
    {
        BlogSiteDBEntities db = new BlogSiteDBEntities();
        BulkMessage bulkMessage = new BulkMessage();
        public List<Project> ProjectList()
        {
            return db.Project.ToList();
        }

        public string CreateProject(Project project)
        {
            try
            {
                Project projectAdd = new Project();
                if (!string.IsNullOrWhiteSpace(project.Title) && !string.IsNullOrWhiteSpace(project.Content) && !string.IsNullOrWhiteSpace(project.Beceriler) && !string.IsNullOrWhiteSpace(project.Sure) && !string.IsNullOrWhiteSpace(project.Fiyat.ToString()) && !string.IsNullOrWhiteSpace(project.Url))
                {
                    projectAdd.Title = project.Title;
                    projectAdd.Content = project.Content;
                    projectAdd.Beceriler = project.Beceriler;
                    projectAdd.Sure = project.Sure;
                    projectAdd.Fiyat = project.Fiyat;
                    projectAdd.Url = project.Url;
                    db.Project.Add(projectAdd);
                    int result = db.SaveChanges();

                    return bulkMessage.AddMessage(result, project.Title + "");
                }
                return bulkMessage.RequiredField(project.Title.ToString());
            }
            catch (Exception)
            {
                return bulkMessage.CatchMessage(project.Title);
            }

        }


        public string UpdateProject(Project project)
        {
            var update = FindProject(project.Id);
            if (update != null)
            {
                if (!string.IsNullOrWhiteSpace(project.Title) && !string.IsNullOrWhiteSpace(project.Fiyat.ToString()) && !string.IsNullOrWhiteSpace(project.Sure))
                {
                    update.Title = project.Title;
                    update.Content = project.Content;
                    update.Beceriler = project.Beceriler;
                    update.Sure = project.Sure;
                    update.Fiyat = project.Fiyat;
                    update.Url = project.Url;
                    
                    int result = db.SaveChanges();
                    return bulkMessage.UpdateMessage(project.Title, result);
                }
                return bulkMessage.RequiredField(project.Content, project.Title);
            }
            return "hata";
        }
        public Project FindProject(int id)
        {
            var getProject = db.Project.Where(x => x.Id == id).SingleOrDefault();
            return getProject;
        }

        public string DeleteProject(int Id)
        {
            if (Id > 0)
            {
                var deleteProject = FindProject(Id);
                if (deleteProject != null)
                {
                    db.Project.Remove(deleteProject);
                    int result = db.SaveChanges();
                    return bulkMessage.DeleteMessage(deleteProject.Title, result);
                }
            }
            return "Makale silmek için makale seçimi yapılmadı";
        }
    }
}
