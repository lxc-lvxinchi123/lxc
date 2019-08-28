using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_UI.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Left(int? id)
        {
            if (!id.HasValue)
                return RedirectToAction("Index", "Home");
            ViewBag.cid = id;

            ViewBag.list = new BLL.Products().GetAllID(id.Value);
            return View();
        }

        public ActionResult Details(int id)
        {
            
            return View(new BLL.Products().FindID(id));

        }
    }
}