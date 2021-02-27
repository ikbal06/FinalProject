using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime ="Sistem bakımda";
        public static string ProductsListed ="Ürünler listelendi";
        internal static string ProductCountOfCategoryError="Bir kategoride en fazla 10 ürün olabilir";
        internal static string ProductNameAlreadyExists="Bu isimde zaten başka bir ürün var";
        internal static string CategoryLimitExceted="Kategori sınırı aşıldığından yeni kategori eklenemiyor";
        internal static string AuthorizationDenied = "Yetkiniz yok.";
        internal static string UserRegistered="Kayıt oldu";
        internal static string UserNotFound = "Kullanıcı bulunamadı";
        internal static string PasswordError = "Parola hatası";
        internal static string SuccessfulLogin ="Başarılı giriş";
        internal static string UserAlreadyExists = "Kullanıcı mevcut";
        internal static string AccessTokenCreated = "Token oluşturuldu";
    }
}
