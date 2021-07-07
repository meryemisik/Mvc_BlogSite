using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MI.AriBilgi.DLL;
namespace MI.AriBilgi.BLL
{
    public class CategoryManager
    {
        BlogSiteDBEntities db = new BlogSiteDBEntities();
        BulkMessage bulkMessage = new BulkMessage();
        public List<Categories> CategoryList()
        {
            var list = db.Categories.ToList();
            return list;
        }

        public object GetCategoryNameByCategoryId(int categoryId)
        {
            var categoryName = db.Categories.Where(k => k.Id == categoryId).SingleOrDefault().CategoryName;
            return categoryName;
        }

        public string CreateCategory(Categories categories)
        {
            try
            {
                Categories categoriesAdd = new Categories();
                if (!string.IsNullOrWhiteSpace(categories.CategoryName) )
                {
                    categoriesAdd.CategoryName = categories.CategoryName;
                   
                    db.Categories.Add(categoriesAdd);
                    int result = db.SaveChanges();
                    return bulkMessage.AddMessage(result, categories.CategoryName + "");
                }
                return bulkMessage.RequiredField(categories.CategoryName.ToString());
            }
            catch (Exception)
            {
                return bulkMessage.CatchMessage(categories.CategoryName);
            }

        }

        public string UpdateCategory(Categories categories)
        {
            var update = FindCategory(categories.Id);
            if (update != null)
            {
                if (!string.IsNullOrWhiteSpace(categories.CategoryName))
                {
                    update.CategoryName = categories.CategoryName;
                    
                    int result = db.SaveChanges();
                    return bulkMessage.UpdateMessage(categories.CategoryName, result);
                }
                return bulkMessage.RequiredField(categories.CategoryName, "");
            }
            return "hata";
        }
        public Categories FindCategory(int id)
        {
            var getCategory = db.Categories.Where(x => x.Id == id).SingleOrDefault();
            return getCategory;
        }

        public string DeleteCategory(int Id)
        {
            if (Id > 0)
            {
                var deleteCategory = FindCategory(Id);
                if (deleteCategory != null)
                {
                    db.Categories.Remove(deleteCategory);
                    int result = db.SaveChanges();
                    return bulkMessage.DeleteMessage(deleteCategory.CategoryName, result);
                }
            }
            return "Makale silmek için makale seçimi yapılmadı";
        }
    }
}

