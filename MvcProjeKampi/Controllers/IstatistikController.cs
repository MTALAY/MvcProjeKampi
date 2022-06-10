using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class IstatistikController : Controller
    {
        CategoryManeger cm = new CategoryManeger(new EfCategoryDal());
        public ActionResult Index()
        {
            var value = cm.GetList();
            return View(value);
        }
    }
}