using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomeWork_Day1.Models;

namespace HomeWork_Day1.Controllers
{
    public class HomeWorkDay1Controller : Controller
    {
        public ActionResult Index()
        {
            return View();
        } 
        public ActionResult MoneyList()
        {
            var source = new List<MoneyModel>();
            source.Add(new MoneyModel
            {
                Category = "支出",
                Date = DateTime.Now.AddDays(1),
                Money = 1000,
                Description="吃飯支出"
            });
            source.Add(new MoneyModel
            {
                Category = "收入",
                Date = DateTime.Now.AddDays(10),
                Money = 10000,
                Description = "工讀收入"
            });
            source.Add(new MoneyModel
            {
                Category = "支出",
                Date = DateTime.Now.AddDays(20),
                Money = 2000,
                Description = "旅遊支出"
            });
            return View(source);
        }
    }
}