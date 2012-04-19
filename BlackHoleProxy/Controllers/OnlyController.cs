using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlackHoleProxy.Controllers
{
    public class OnlyController : Controller
    {
        public ActionResult Index()
        {
            return new EmptyResult();
        }
    }
}
