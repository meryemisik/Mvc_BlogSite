using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MI.AriBilgi.DLL;
namespace MI.AriBilgi.BLL
{
   public class ArticleManager
    {
        BlogSiteDBEntities db = new BlogSiteDBEntities();
        BulkMessage bulkMessage = new BulkMessage();
        public List<Articles> ArticleList()
        {         
            return db.Articles.ToList();
        }

        public string CreateArticle(Articles articles)
        {
            try
            {
                Articles articlesAdd = new Articles();
                //if (!string.IsNullOrWhiteSpace(articles.Title) && !string.IsNullOrWhiteSpace(articles.Content) )
                //{
                    articlesAdd.Title = articles.Title;
                    articlesAdd.Content = articles.Content;
                    articlesAdd.CreateDate = DateTime.Now;
                    articlesAdd.CategoryID = articles.CategoryID;
                    articlesAdd.UyeID = articles.UyeID;
                    db.Articles.Add(articlesAdd);
                   int result= db.SaveChanges();
                    return bulkMessage.AddMessage(result, articles.Title+"");
                //}
                //return bulkMessage.RequiredField(articles.Title.ToString(), articles.Content.ToString(), articles.CategoryID.ToString());
            }
            catch (Exception)
            {
                return bulkMessage.CatchMessage(articles.Title);
            }
            
        }

        public string UpdateArticle(Articles articles)
        {
            
                var update = FindArticle(articles.Id);
                if (update != null)
                {
                    if (!string.IsNullOrWhiteSpace(articles.Content) && !string.IsNullOrWhiteSpace(articles.Title))
                    {
                        update.Title = articles.Title;
                        update.Content = articles.Content;
                        update.UyeID = articles.UyeID;
                        update.CategoryID = articles.CategoryID;
                        update.CreateDate = DateTime.Now;
                        int result = db.SaveChanges();
                        return bulkMessage.UpdateMessage(articles.Title, result);
                    }
                return bulkMessage.RequiredField(articles.Content, articles.Title);
                }
            return "hata";
        }
        public Articles FindArticle(int id)
        {
            var getArticle = db.Articles.Where(x => x.Id == id).SingleOrDefault();
            return getArticle;
        }
      
        public string DeleteArticle(int Id)
        {
            if (Id > 0)
            {
                var deleteArticle = FindArticle(Id);
                if (deleteArticle != null)
                {
                    db.Articles.Remove(deleteArticle);
                    int result = db.SaveChanges();
                    return bulkMessage.DeleteMessage(deleteArticle.Id.ToString(), result);
                }
            }
            return "Makale silmek için makale seçimi yapılmadı";
        }
     
    }
}
