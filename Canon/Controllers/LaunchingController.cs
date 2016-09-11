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
        static List<Launching> launching = new List<Launching>();

        public ActionResult getVelocidad(float Velocidad, float Angulo)
        {
            launching.Add(new Launching() { Id = 1, IdGamer = 2, Angle = Angulo, Velocidad = Velocidad });
            return Json(launching, JsonRequestBehavior.AllowGet);
        }

        public ActionResult getLaunching()
        {
            return Json(launching, JsonRequestBehavior.AllowGet);
        }

        public ActionResult getChoque(int id)
        {

            var choque = launching.FirstOrDefault((c) => c.Id == id);
            return Json(choque.Id, JsonRequestBehavior.AllowGet);
        }
    }
}