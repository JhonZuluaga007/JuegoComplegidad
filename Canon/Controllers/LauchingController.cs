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
        static List<Launching> lauching = new List<Launching>();

        public ActionResult getVelocidad(float Velocidad,float Angulo  )
        {  
            lauching.Add( new Launching(){ Id = 1, IdGamer = 2, Angle=Angulo, Velocidad=Velocidad});
            return Json(lauching, JsonRequestBehavior.AllowGet);
        }

        public ActionResult getLauching()
        {
            return Json(lauching, JsonRequestBehavior.AllowGet);
        }
    }
}
