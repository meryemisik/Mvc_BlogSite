using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MI.AriBilgi.DLL;
namespace MI.AriBilgi.BLL
{
   public class ServicesManager
    {
        BlogSiteDBEntities db = new BlogSiteDBEntities();
        BulkMessage bulkMessage = new BulkMessage();
        public List<Service> ServicesList()
        {
            return db.Service.ToList();
        }

        public string CreateServices(Service service)
        {
            try
            {
                Service serviceAdd = new Service();
                if (!string.IsNullOrWhiteSpace(service.ServiceAdi) )
                {
                    serviceAdd.ServiceAdi = service.ServiceAdi;
                   
                    db.Service.Add(serviceAdd);
                    int result = db.SaveChanges();

                    return bulkMessage.AddMessage(result, service.ServiceAdi + "");
                }
                return bulkMessage.RequiredField(service.ServiceAdi);
            }
            catch (Exception)
            {
                return bulkMessage.CatchMessage(service.ServiceAdi);
            }

        }

        public string UpdateServices(Service service)
        {
            var update = FindServices(service.ServiceId);
            if (update != null)
            {
                if (!string.IsNullOrWhiteSpace(service.ServiceAdi))
                {
                    update.ServiceAdi = service.ServiceAdi;                 
                    int result = db.SaveChanges();
                    return bulkMessage.UpdateMessage(service.ServiceAdi, result);
                }
                return bulkMessage.RequiredField(service.ServiceAdi, "");
            }
            return "hata";
        }
       
        public Service FindServices(int id)
        {
            var getService = db.Service.Where(x => x.ServiceId == id).SingleOrDefault();
            return getService;
        }

        public string DeleteService(int Id)
        {
            if (Id > 0)
            {
                var deleteService = FindServices(Id);
                if (deleteService != null)
                {
                    db.Service.Remove(deleteService);
                    int result = db.SaveChanges();
                    return bulkMessage.DeleteMessage(deleteService.ServiceId.ToString(), result);
                }
            }
            return "Makale silmek için makale seçimi yapılmadı";
        }


    }
}
