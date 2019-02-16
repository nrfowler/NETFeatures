using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EventController : Controller
    {
        private UniversityEntities db = new UniversityEntities();

        // GET: Event
        public ActionResult Index()
        {
            #region Collapsible Region
            return View();
            #endregion
        }
    }
}