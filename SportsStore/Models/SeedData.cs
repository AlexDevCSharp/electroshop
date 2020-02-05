using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace SportsStore.Models {

    public static class SeedData {

        public static void EnsurePopulated(IApplicationBuilder app) {
            ApplicationDbContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Products.Any()) {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Ihone 11",
                        Description = "Мобильный телефон Apple iPhone 11 256GB",
                        Category = "Phones",
                        Price = 30
                    },
                    new Product
                    {
                        Name = "Ihone 11 pro",
                        Description = "Мобильный телефон Apple iPhone 11 Pro 256GB",
                        Category = "Phones",
                        Price = 40
                    },
                    new Product
                    {
                        Name = "Samsung M30",
                        Description = "Мобильный телефон Samsung Galaxy M30s 4/64GB",
                        Category = "Phones",
                        Price = 6.35m
                    },
                    new Product
                    {
                        Name = "Samsung Galaxy S10 Plus",
                        Description = "Мобильный телефон Samsung Galaxy S10 Plus 8/128GB",
                        Category = "Phones",
                        Price = 26.95m
                    },
                    new Product
                    {
                        Name = "Meizu 16X",
                        Description = "Мобильный телефон Meizu 16X 6/64GB",
                        Category = "Phones",
                        Price = 8.3m
                    },
                    new Product
                    {
                        Name = "HTC U11",
                        Description = "Смартфон HTC U11 4/64GB Black",
                        Category = "Phones",
                        Price = 7.3m
                    },
                    new Product
                    {
                        Name = "Apple AirPods Pro",
                        Description = "Наушники Apple AirPods Pro",
                        Category = "Headphones",
                        Price = 8.49m
                    },
                    new Product
                    {
                        Name = "Apple iPhone EarPods",
                        Description = "Наушники Apple iPhone EarPods with Mic Lightning",
                        Category = "Headphones",
                        Price = 1.09m
                    },
                    new Product
                    {
                        Name = "JBL LIVE 650",
                        Description = "Наушники JBL LIVE 650 BT NC",
                        Category = "Headphones",
                        Price = 3.99m
                    },
                    new Product
                    {
                        Name = "JBL Tune",
                        Description = "Наушники JBL Tune 220 TWS",
                        Category = "Headphones",
                        Price = 2.49m
                    },
                    new Product
                    {
                        Name = "Marshall MID A.N.C BT",
                        Description = "Наушники Marshall MID A.N.C BT Black 4092138",
                        Category = "Headphones",
                        Price = 14.4m
                    },
                    new Product
                    {
                        Name = "Marshall Mid",
                        Description = "Marshall Mid Bluetooth ANC",
                        Category = "Headphones",
                        Price = 6.99m
                    },
                    new Product
                    {
                        Name = "Apple iPad Pro 12.9",
                        Description = "Планшет Apple iPad Pro 12.9 2018 Wi-Fi + Cellular 1TB Silver ",
                        Category = "Tablets",
                        Price = 61.53m
                    },
                    new Product
                    {
                        Name = "iPad Pro 11",
                        Description = "Apple iPad Pro 11 A1980 Wi - Fi 512GB 2018",
                        Category = "Tablets",
                        Price = 39.29m
                    },
                    new Product
                    {
                        Name = "Asus Z500KL",
                        Description = "Планшет Asus Z500KL ZenPad",
                        Category = "Tablets",
                        Price = 26.57m
                    },
                    new Product
                    {
                        Name = "Acer One 10",
                        Description = "Планшет Acer One 10 S1003P-179H 10.1",
                        Category = "Tablets",
                        Price = 12.37m
                    },
                    new Product
                    {
                        Name = "Lenovo IdeaPad Miix 520",
                        Description = "Планшет Lenovo IdeaPad Miix 520 12.2 FullHD LTE 8 / 256GB Win10P Platinum",
                        Category = "Tablets",
                        Price = 50.14m
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
