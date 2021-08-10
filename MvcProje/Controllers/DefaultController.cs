using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        // GET: Default
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        ContentManager cm = new ContentManager(new EfContentDal());
        public PartialViewResult Index(int id=9)
        {
            var contentList = cm.GetListByHeadingID(id);
            return PartialView(contentList);
        }
        public ActionResult Headings()
        {
            var headingList = hm.GetList();
            return View(headingList);
        }
    }
}