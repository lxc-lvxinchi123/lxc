using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_UI.Controllers
{
    public class ReviewsController : Controller
    {
        // GET: Reviews
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List(int id)
        {
            
            return PartialView(new BLL.Reviews().GetReviewsByID(id));
        }

        public ActionResult Add()
        {
            return PartialView();
        }
    }
}