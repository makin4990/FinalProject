using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Core.Entities.Concrete;
using Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün İsmi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductListed ="Ürünler listelendi";

        public static string AuthorizationDenied = "Yetkisiz Erişim";
        public static string UserRegistered = "Kullanıcı kaydedildi";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError ="Hatalı parola";
        public static string SuccessfulLogin ="Başarılı bir şekildi giriş yapıldı";
        public static string UserAlreadyExists = "Kullanıcı  zaten sistemde mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu.";
    }
}
