using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    //static veirnce new lenmez direkt çağrılır.
   public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameınvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Bakım zamanı";

        public static string ProductNameAlreadyExist = "Product İsmi Hali hazırda var!";
        public static string AuthorizationDenied = "Erişim Yok!";

        public static string UserRegistered { get; internal set; }
        public static User UserNotFound { get; internal set; }
        public static User PasswordError { get; internal set; }
    }
}
