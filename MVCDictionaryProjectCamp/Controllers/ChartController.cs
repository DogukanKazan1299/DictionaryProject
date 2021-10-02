using MVCDictionaryProjectCamp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDictionaryProjectCamp.Controllers
{
    public class ChartController : Controller
    {
        // GET: Chart
        public ActionResult Index()
        {
            return View();
        }

        public List<CategoryClass> BlogList()
        {
            List<CategoryClass> ct = new List<CategoryClass>();
            ct.Add(new CategoryClass()
            {
                CategoryName="Yazılım",
                CategoryCount=10
            });
            ct.Add(new CategoryClass()
            {
                CategoryName = "Dizi",
                CategoryCount = 17
            });
            ct.Add(new CategoryClass()
            {
                CategoryName = "Film",
                CategoryCount = 15
            });
            ct.Add(new CategoryClass()
            {
                CategoryName = "Ulaşım",
                CategoryCount = 5
            });
            ct.Add(new CategoryClass()
            {
                CategoryName = "Seyahat",
                CategoryCount = 2
            });
            ct.Add(new CategoryClass()
            {
                CategoryName = "Sinema",
                CategoryCount = 40
            });
            ct.Add(new CategoryClass()
            {
                CategoryName = "Spor",
                CategoryCount = 12
            });
            return ct;
        }

        public ActionResult CategoryChart()
        {
            return Json(BlogList(), JsonRequestBehavior.AllowGet);
        }
    }
}