using Canon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace Canon.Controllers
{
    public class LauchingController : Controller
    {

        Launching[] Launchinges = new Launching[]
        {
            new Launching {Id=1, IdGamer=01, Angle= 23456, Power=98},
            new Launching {Id=2, IdGamer=02, Angle= 97656, Power=00}
        };


        public ActionResult getLauching(int id)
        {
            var lauching = Launchinges.FirstOrDefault((c) => c.Id == id);
            return Json(Launchinges, JsonRequestBehavior.AllowGet);
        }


    }
}
