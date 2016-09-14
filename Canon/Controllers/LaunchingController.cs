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

        public ActionResult getVelocidad(int Idpartidad,int IdGamer,bool Idturno, float Velocidad, float Angulo)
        {
           

           
            launching.Add(new Launching() {Departure = Idpartidad, IdGamer = IdGamer, Angle = Angulo, Velocidad = Velocidad });
            return Json(new Launching() { Departure = Idpartidad, IdGamer = IdGamer, Angle = Angulo, Velocidad = Velocidad }, JsonRequestBehavior.AllowGet); 
        }
        public ActionResult getMove(int Id, int IdGamer){
           var Launching = launching.FirstOrDefault((c) => c.Departure == Id && c.IdGamer != IdGamer);
           
                int ss = launching.IndexOf(Launching);
                
                launching.RemoveAt(ss);
                return Json(Launching, JsonRequestBehavior.AllowGet);
           
          
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