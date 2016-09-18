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

        public void getVelocidad(int Idpartidad, float Velocidad, float Angulo)
        {

            launching.Add(new Launching() { Departure = Idpartidad, Angle = Angulo, Velocidad = Velocidad });
            //return Json(new Launching() { Departure = Idpartidad, IdGamer = IdGamer, Angle = Angulo, Velocidad = Velocidad }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult getMove(int Idpartida)
        {
            if (launching.Count != 0)
            {
                var Launching = launching.FirstOrDefault((c) => c.Departure == Idpartida);

                int ss = launching.IndexOf(Launching);

                launching.RemoveAt(ss);
                return Json(Launching, JsonRequestBehavior.AllowGet);
            }
            return null;
        }

        public ActionResult getLaunching()
        {
            return Json(launching, JsonRequestBehavior.AllowGet);

        }
        public ActionResult getChoque(int id)
        {
            var choque = launching.FirstOrDefault((c) => c.Departure == id);
            return Json(choque.Departure, JsonRequestBehavior.AllowGet);
        }
    }
}