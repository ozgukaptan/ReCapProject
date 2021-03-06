using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Bussines.Constants
{
    public static class Messages
    {
        public static string BrandAdded = "Marka eklendi";
        public static string BrandNameInvalid = "Marka ismi İki karakterden kısa olmaz";
        public static string BrandDeleted = "Marka Silindi";

        public static string CarAdded = "Araba eklendi";
        public static string RentalCarInvalid = "Bu araba kiralanamaz çünkü teslim edilmedi";

        public static string UserFirstNameInvalid = "Kullanıcı adı kısa";

        public static string CarImageLimitExceeded = "bir arabanın birden fazla fotoğrafı olamaz";

        public static string AuthorizationDenied = "Yetkiniz Yok.";

        public static string UserRegistered = "Kayıt olundu";

        public static string UserNotFound = "kullanıcı bulunamadı";

        public static string PasswordError = "Parola hatalı";
        public static string SuccessfulLogin = "Giriş Başarılı";

        public static string UserAlreadyExists = "Bu kullanıcı var";

        public static string AccessTokenCreated = "Token oluşturuldu";
    }

}
