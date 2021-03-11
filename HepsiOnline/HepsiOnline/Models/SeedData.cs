using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace HepsiOnline.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
            .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                new Product
                {
                    Name = "Xiaomi Mi 8 Lite",
                    Description = "Ekran Boyutu: 6.26 İnç   Dahili Depolama: 64 GB   Bellek(RAM): 4 GB   Batarya Kapasitesi: 3350 mAh.   Hat Sayısı: Çift Hat   Hızlı Şarj   4.5G Desteği   CPU Frekansı: 2.2 GHz.",
                    Category = "Telefon",
                    Price = 2199.99m,
                    ImageAdress = "/Images/xiaomi-mi-8-lite.jpg"
                },
                new Product
                {
                    Name = "Ipad Pro",
                    Description = "Kamera: Çift Kamera   İşletim Sistemi: IOS   Dahili Hafıza: 128 GB   Ekran Modeli: IPS Ekran   Ram Kapasitesi: 6 GB   Ekran Boyutu: 11 inç",
                    Category = "Tablet",
                    Price = 6999.99m,
                    ImageAdress = "/Images/ipad-pro-tablet.png"
                },
                new Product
                {
                    Name = "Casio Kol Saati",
                    Description = "EFV-570L-2BVUDF   Erkek Kol Saati",
                    Category = "Kol Saati",
                    Price = 579.99m,
                    ImageAdress = "/Images/casio-kol-saati.jpg"
                },
                new Product
                {
                    Name = "Nostaljik Nokia 3310",
                    Description = "Dahili Hafıza: 16 MB   Ekran Boyutu2,4 inç   Kamera Çözünürlüğü: 2 MP   Yılan Oyunu: Var",
                    Category = "Telefon",
                    Price = 149,
                    ImageAdress = "/Images/nokia-3310.png"
                },
                new Product
                {
                    Name = "Samsung Galaxy Note 20 Ultra",
                    Description = "Ekran boyutu	6.9   Görüntülenen renk sayısı: 16 milyon renk   Arka Kamera Çözünürlüğü: 108 MP   Ön Kamera Çözünürlüğü: 10 MP",
                    Category = "Telefon",
                    Price = 11899,
                    ImageAdress = "/Images/samsung-note-20-u.jpg"
                },
                new Product
                {
                    Name = "Elektrikli Çim Biçme Makinesi",
                    Description = "Hyundai C3200   Kesim genişliği: 32 cm   Kesim Yüksekliği: 25 - 55 mm",
                    Category = "Bahçe",
                    Price = 549,
                    ImageAdress = "/Images/cim-bicme.jpg"
                },
                new Product
                {
                    Name = "Barbekü",
                    Description = "Daiwa   Dayanıklı alev ızgarası   Mat siyah yanmaz boya",
                    Category = "Bahçe",
                    Price = 4100,
                    ImageAdress = "/Images/barbeku.png"
                },
                new Product
                {
                    Name = "Casper Via",
                    Description = "Kamera: Var   İşletim Sistemi: Android   Dahili Hafıza: 32 GB   Ekran Modeli: IPS Ekran   Ram Kapasitesi: 3 GB   Ekran Boyutu: 8 inç",
                    Category = "Tablet",
                    Price = 1107,
                    ImageAdress = "/Images/casper-via-tablet.jpg"
                },
                new Product
                {
                    Name = "Ahşap Masa + 4 Ahşap Tabure",
                    Description = "1 Adet 70*70cm. Masa ve 4 Adet 30*30cm. Tabureden oluşmaktadır.   Ayakları 1.sınıf yerli kayın ağacından üretilmiştir.",
                    Category = "Bahçe",
                    Price = 849,
                    ImageAdress = "/Images/masa-tabure.jpg"
                }
                );
                 context.SaveChanges();
            }
         }
    }
}
