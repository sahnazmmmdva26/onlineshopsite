using Microsoft.AspNetCore.Mvc;
using onlineshopsite.Models;
using static System.Net.Mime.MediaTypeNames;

namespace onlineshopsite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Product> Products = new List<Product>();
            Products.Add(new Product()
            {
                Id = 1,
                Name = "Cozy Crewneck Sweater",
                Image = "product-2.jpg",
                Price = 25,
                Description = "100% Shetland wool\r\nImported\r\nPull On closure\r\nHand Wash Only\r\nribbed neck, cuff and hem"
            });
            Products.Add(new Product()
            {
                Id = 2,
                Name = "Mouse",
                Image = "Mouse1.jpg",
                Price = 80,
                Description = "About this item\r\nCestus 350 supports 2.4GHz wireless at 1ms/1000Hz and wired with 0.5ms/2000Hz.\r\nUse NVIDIA’s Reflex Latency Analyzer to measure exactly how long it takes for your click to register on screen.\r\nSensor: Pixart 3335 | Maximum DPI: Up to 16,000 | DPI Setting: 5-Level DPI Shift Setting with LED Indicator\r\nFive Onboard Memory Profiles: Save profiles to the mouse once for gameplay on different computers and assign lighting colors to easily see which profile you're using Predator Quarter Master Software.\r\n8 Programmable Buttons: Allows for button remapping and assignment of complex macro functions using Predator Quarter Master Software.\r\nCustomize settings, such as lighting, button assignment and more via Predator Quarter Master"
            });
            Products.Add(new Product()
            {
                Id = 3,
                Name = "Camera",
                Image = "product-1.jpg",
                Price = 120,
                Description = "Brand\tPentax\r\nModel Name\tPentax K-70\r\nForm Factor\tMid size SLR\r\nEffective Still Resolution\t24.2 MP\r\nSpecial Feature\tD-Rings, Handheld, Shoulder Strap, Trolley Sleeve\r\nOptical Zoom\t3 x"
            });
            Products.Add(new Product()
            {
                Id = 4,
                Name = "Lamp",
                Image = "product-3.jpg",
                Price = 50,
                Description = "\r\nStyle\tModern\r\nBrand\tSimple Designs\r\nColor\tGold/White\r\nProduct Dimensions\t7\"D x 7\"W x 13.5\"H\r\nLight Source Type\tIncandescent"
            });
            Products.Add(new Product()
            {
                Id = 5,
                Name = "Black Shoe",
                Image = "product-4.jpg",
                Price = 25,
                Description = "100% Man Made\r\nMan Made sole\r\nCushioned Insole for added comfort\r\nWater Resistant Synthetic Leather upper\r\nSlip resistant rubber outsole\r\nLace up closure for an adjustable, secure fit, featuring custom eyelets and classic Lugz hardware\r\nBreathable lining"
            });
            Products.Add(new Product()
            {
                Id = 6,
                Name = "Watch",
                Image = "product-6.jpg",
                Price = 75,
                Description = "\r\nBrand\tAmazfit\r\nModel Name\tAmazfit Bip\r\nStyle\tBip 3 Pro Newer Model\r\nColor\tBlack-Pro\r\nScreen Size\t1.69 Inches\r\nSpecial Feature\tWireless, Universal\r\nAge Range (Description)\tAdult\r\nCompatible Devices\tSmartphone\r\nDisplay Type\tLCD\r\nOperating System\tZepp OS"
            });
            Products.Add(new Product()
            {
                Id = 7,
                Name = "Black Woman Shirt",
                Image = "product-7.jpg",
                Price = 66,
                Description = "100% Polyester\r\nImported\r\nNo Closure closure\r\nMachine Wash\r\nHANES SPORT – Performance. Style. Comfort. Hanes Sport apparel builds on our comfort heritage with innovative technologies to give you the looks that fit your life, your sport, and your style.\r\nSTAY COOL – Powered by Cool Dri technology, these long sleeve tees dry faster so you stay comfortable.\r\nODOR CONTROL – Thanks to FreshIQ advanced odor protection technology, you can feel fresher all day."
            });
            Products.Add(new Product()
            {
                Id = 8,
                Name = "Cream",
                Image = "product-8.jpg",
                Price = 100,
                Description = "[ HYALURONIC ACID MOISTURIZER ] With hyaluronic acid, ceramides and MVE technology for 24 hour hydration. Rich, velvety texture that leaves skin feeling smooth, it is absorbed quickly for softened skin without greasy, sticky, feel.\r\n[ ESSENTIAL CERAMIDES ] Ceramides are found naturally in the skin and make up 50% of the lipids in the skin barrier. All CeraVe products are formulated with three essential ceramides (1, 3, 6-II) to help restore and maintain the skin’s natural barrier.\r\n[ DRY SKIN RELIEF ] A deficiency of ceramides in skin can often be associated with dry skin, which can feel itchy and look flaky. CeraVe Moisturizing Cream was shown to increase the skin's level of ceramides after 4 weeks.\r\n[ DERMATOLOGIST RECOMMENDED ] CeraVe Skincare is developed with dermatologists and has products suitable for dry skin, sensitive skin, oily skin, acne-prone, and more. This skin care product comes with a lid seal\r\n[ GENTLE DAILY MOISTURIZER ] For face and body or can be used as a hand cream for dry skin relief. Holds National Eczema Association (NEA) Seal of Acceptance. Fragrance free, paraben free, allergy-tested, and non-comedogenic."
            });
            Products.Add(new Product()
            {
                Id = 9,
                Name = "Office Chair",
                Image = "product-9.jpg",
                Price = 125,
                Description = "Color\tBlue\r\nBrand\tBestOffice\r\nProduct Dimensions\t22.6\"D x 23.2\"W x 37\"H\r\nStyle\tModern\r\nMaterial\tNylon"
            });
            List<Category> categories = new List<Category>();
            categories.Add(new Category() { Id = 1, Name = "Clothes",Image="cat-1.jpg" });
            categories.Add(new Category() { Id = 1, Name = "Electronics", Image = "cat-2.jpg" });
            categories.Add(new Category() { Id = 1, Name = "Shoes", Image = "cat-3.jpg" });
            categories.Add(new Category() { Id = 1, Name = "Cosmetics", Image = "cat-4.jpg" });
            ViewBag.Categories = categories;
            return View(Products);
        }
        public IActionResult Detail()
        { 
            return View(); 
        }
        public IActionResult Shop() 
        { 
            return View(); 
        }
    }
}
