using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MI.AriBilgi.DLL;
namespace MI.AriBilgi.BLL
{
   public class UyelerManager
    {
        BlogSiteDBEntities db = new BlogSiteDBEntities();
        BulkMessage bulkMessage = new BulkMessage();
        public List<Uyeler> UyelerList()
        {
            return db.Uyeler.ToList();
        }

        public object GetUyeNameByUyeId(int uyeId)
        {
            var uyeName = db.Uyeler.Where(k => k.Id == uyeId).SingleOrDefault().UyeAdi;
            return uyeName;
        }

        public object GetYetkiNameByYetkiId(int yetkiId)
        {
            var yetkiName = db.Yetkiler.Where(k => k.Id == yetkiId).SingleOrDefault().YetkiAdi;
            return yetkiName;
        }

        public string CreateUyeler(Uyeler uyeler)
        {
            try
            {
                Uyeler uyeAdd = new Uyeler();
                if (!string.IsNullOrWhiteSpace(uyeler.UyeAdi) && !string.IsNullOrWhiteSpace(uyeler.UyeSifre) && !string.IsNullOrWhiteSpace(uyeler.YetkiId.ToString()) && !string.IsNullOrWhiteSpace(uyeler.Yazarmi.ToString()) && !string.IsNullOrWhiteSpace(uyeler.Aktifmi.ToString()))
                {
                    uyeAdd.UyeAdi = uyeler.UyeAdi;
                    uyeAdd.UyeSifre = uyeler.UyeSifre;
                    uyeAdd.YetkiId = uyeler.YetkiId;
                    uyeAdd.Yazarmi = uyeler.Yazarmi;
                    uyeAdd.Aktifmi = uyeler.Aktifmi;
                    uyeAdd.UyelikTarih = DateTime.Now;
                    db.Uyeler.Add(uyeAdd);
                    int result = db.SaveChanges();

                    return bulkMessage.AddMessage(result, uyeler.UyeAdi + "");
                }
                return bulkMessage.RequiredField(uyeler.UyeAdi);
            }
            catch (Exception)
            {
                return bulkMessage.CatchMessage(uyeler.UyeAdi);
            }

        }

        public string UpdateUye(Uyeler uyeler)
        {
            var update = FindUye(uyeler.Id);
            if (update != null)
            {
                if (!string.IsNullOrWhiteSpace(uyeler.UyeAdi) && !string.IsNullOrWhiteSpace(uyeler.UyeSifre) && !string.IsNullOrWhiteSpace(uyeler.Yazarmi.ToString()) && !string.IsNullOrWhiteSpace(uyeler.Aktifmi.ToString()) && !string.IsNullOrWhiteSpace(uyeler.YetkiId.ToString()))
                {
                    update.UyeAdi = uyeler.UyeAdi;
                    update.UyeSifre = uyeler.UyeSifre;
                    update.Yazarmi = uyeler.Yazarmi;
                    update.UyelikTarih = DateTime.Now;
                    update.Aktifmi = uyeler.Aktifmi;
                    update.YetkiId = uyeler.YetkiId;
                    int result = db.SaveChanges();
                    return bulkMessage.UpdateMessage(uyeler.UyeAdi, result);
                }
                return bulkMessage.RequiredField(uyeler.UyeAdi,"");
            }
            return "hata";
        }
        public Uyeler FindUye(int id)
        {
            var getUye = db.Uyeler.Where(x => x.Id == id).SingleOrDefault();
            return getUye;
        }
        public Uyeler FindUyeName(int id)
        {
            var getUye = db.Uyeler.Where(x => x.Id == id).FirstOrDefault();
            return getUye;
        }

        public string DeleteUye(int Id)
        {
            if (Id > 0)
            {
                var deleteUye = FindUye(Id);
                if (deleteUye != null)
                {
                    db.Uyeler.Remove(deleteUye);
                    int result = db.SaveChanges();
                    return bulkMessage.DeleteMessage(deleteUye.Id.ToString(), result);
                }
            }
            return "Makale silmek için makale seçimi yapılmadı";
        }

    }
}
