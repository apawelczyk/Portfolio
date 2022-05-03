using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public partial class PortfolioController : Controller
    {
        public virtual ActionResult Home()
        {
            return View(MVC.Portfolio.Views.Index);
        }
    }
}