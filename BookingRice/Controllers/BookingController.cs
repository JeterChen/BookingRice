using BookingRice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace BookingRice.Controllers
{
    public class BookingController : Controller
    {
        // GET: Booking/Index?category=xxx
        public ActionResult Index(string category)
        {
            if (string.IsNullOrEmpty(category))
            {
               return View(GetMenu());
            }
            else
            {
                var riceModel = GetMenu();
                riceModel.category = category;
                riceModel.Menus = riceModel.Menus.Where(m => m.Category.Equals(category)).ToList();
                return View(riceModel);
            }
        }
          
        // GET: Booking/StringPage 回傳 String
        public String StringPage()
        {
            return "Booking Page";
        }


        // GET: Booking/Categorys 回傳 Json
        public JsonResult Categorys()
        {
            var categorys = new object[]
            {
                 new
                {
                    Name = "----請選擇----"
                },
                new
                {
                    Name = "便當"
                },
                new
                {
                    Name = "炒飯"
                },
                new
                {
                    Name = "燴飯"
                },
                new
                {
                    Name = "炒麵"
                },
                new
                {
                    Name = "湯麵"
                },
                new
                {
                    Name = "小菜"
                }
            };
            return Json(categorys, JsonRequestBehavior.AllowGet);
        }

        private RiceModel GetMenu()
        {
            RiceModel riceModel = new RiceModel();
            List<RiceMenu> Menus = new List<RiceMenu>
            {
                new RiceMenu
                {
                    Category = "便當",
                    Name = "雞腿飯",
                    Price = 100
                },
                new RiceMenu
                {
                    Category = "便當",
                    Name = "排骨飯",
                    Price = 90
                },
                new RiceMenu
                {
                    Category = "便當",
                    Name = "蝦排飯",
                    Price = 90
                },
                new RiceMenu
                {
                    Category = "炒飯",
                    Name = "肉絲炒飯",
                    Price = 60
                },
                new RiceMenu
                {
                    Category = "炒飯",
                    Name = "火腿炒飯",
                    Price = 60
                },
                new RiceMenu
                {
                    Category = "炒飯",
                    Name = "牛肉炒飯",
                    Price = 90
                },
                new RiceMenu
                {
                    Category = "炒飯",
                    Name = "蝦仁炒飯",
                    Price = 80
                },
                 new RiceMenu
                {
                    Category = "湯麵",
                    Name = "切仔麵",
                    Price = 60
                },
                  new RiceMenu
                {
                    Category = "湯麵",
                    Name = "烏龍麵",
                    Price = 70
                },
                    new RiceMenu
                {
                    Category = "湯麵",
                    Name = "乾麵",
                    Price = 30
                }
            };
            riceModel.Menus = Menus;
            return riceModel;
        }
    }
}