using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string CategoryAdded = "Category eklendi";
        public static string OrderAdded = "Sipariş eklendi";
        public static string CustomerAdded = "Müşteri eklendi";
        public static string ProductUpdated = "Ürün güncellendi";
        public static string CategoryUpdated = "Category güncellendi";
        public static string OrderUpdated = "Sipariş güncellendi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string ProductDeleted = "Ürün silindi";
        public static string CategoryDeleted = "Category silindi";
        public static string OrderDeleted = "Sipariş silindi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string ProductListed = "Ürünler listelendi";
        public static string OrderListed = "Siparişler listelendi";
        public static string CustomerListed = "Müşteriler listelendi";
        public static string CategoryListed = "Categoriler listelendi";
        public static string ProductNameInvalide = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string NotFound = "Geçersiz işlem";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "Bu isminde daha önce ürün eklenmiştir";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor";
    }
}
