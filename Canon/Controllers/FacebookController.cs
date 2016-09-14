using Canon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Linq;
using System.Web.Mvc;

namespace Canon.Controllers
{
    public class FacebookController : Controller
    {

        static List<Facebook> facebook = new List<Facebook>();

        public ActionResult getFacebook(string tocken)
        {
            facebook.Add(new Facebook() { tocke = tocken });

            return Json(facebook, JsonRequestBehavior.AllowGet);
        }

        public ActionResult getConsultar(string tocken)
        {

            return Json(facebook, JsonRequestBehavior.AllowGet);
            
        }
    }
}
