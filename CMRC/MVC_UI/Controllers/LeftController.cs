using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;



namespace MVC_UI.Controllers
{
    public class LeftController : Controller
    {
        // GET: Left
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {

            ViewBag.list = new BLL.Category().GetAll();
            CommerceEntities1 dc = new CommerceEntities1();
            return PartialView(dc.CMRC_Categories.ToList());

        }
    }
}