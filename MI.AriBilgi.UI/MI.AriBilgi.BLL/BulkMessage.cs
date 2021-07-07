using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MI.AriBilgi.BLL
{
   public class BulkMessage
    {
        public string AddMessage(int result, params string[] message)
        {
            if (result>0)
            {
                if (message.Length > 0)
                {
                    return message[0] + " başlıklı makale başarılı bir şekilde eklendi";
                }
                else
                {

                }
                return "kontrol ediniz"; 
            }
            return message + " eklenem esnasında hata oluştu";
        }

        public string CatchMessage(params string[] message)
        {
            return message + " try catchte hata oluştu";
        }

        public string DeleteMessage(string message, int result)
        {
            if (result > 0)
            {
                return message + " silinme işlemi başarılı bir şekilde gerçekleşti";
            }
            return message + " silinme işleminde hata oluştu";
        }

        public string UpdateMessage( string message, int result)
        {
            if (result > 0)
            {
                return message + " güncelleme işlemi başarılı bir şekilde gerçekleşti";
            }           
            return message + " güncelleme işleminde hata oluştu";
        }

        public string RequiredField(params string[] message)
        {
            string mx = null;
            foreach (var item in message)
            {
                if (string.IsNullOrWhiteSpace(item))
                {
                    mx= item + " alanını doldurmak zorunludur";
                    break;
                }                
            }
            return mx;
        }
    }
}
