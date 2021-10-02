using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDictionaryProjectCamp.Controllers
{
    public class ContentController : Controller
    {
        // GET: Content

        ContentManager cm = new ContentManager(new EfContentDal());

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ContentByHeading(int id)
        {
            var contentvalues = cm.GetListByHeadingID(id);
            return View(contentvalues);
        }
        Context c = new Context();
        public ActionResult GetAllContent(string p)
        {
            //var values = c.Contents.ToList();
            //p = "çok";
            var values = from x in c.Contents select x;
            if (!string.IsNullOrEmpty(p))
            {
                values = values.Where(y => y.ContentValue.Contains(p));
            }
            return View(values.ToList());
        }


    }
}