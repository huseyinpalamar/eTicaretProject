using Core.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = " Ürün ekleme başarılı";
        public static string TheProductCouldNotBeAdded = "Ürün ekleme başarısız";
        public static string ProductRemoved = "Ürün silme başarılı";
        public static string UpateSuccessful = "Güncelleme başarılı..";
        public static string ListingSuccessful = " Ürün listeleme başarılı..";
        public static string ListingFailed = "Listeleme Başarısız. Sistem bakımda";
        public static string OrderSuccessful = "Sipariş başarılı bir şekilde alındı..";
        public static string OrderRemoved = "Sipariş iptal edildi..";
        public static string ProductNameAlreadyExsists= "Bu isimden ürün bulunmakta";
        public static string AuthorizationDenied = "Yetkisi yok";
        public static string RegistrationSuccess = "Kayıt Başarılı";
        public static string RegistrationFailed = "Kayıt başarısız";
        public static string UserRegistered = "Kullanıcı kayıdı başarılı";
        public static string UserNotFound = "Böyle bir kullanıcı bulunamadı";
        public static string PasswordError = "Şifre Hatalı";
        public static string SuccessfulLogin="Giriş başarılı";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Token üretimi başarılı";
    }
}
