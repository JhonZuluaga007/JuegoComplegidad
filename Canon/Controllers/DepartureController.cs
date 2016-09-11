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
    public class DepartureController : Controller
    {
        static int y ;
        int contador;
        static List<Departure> Partid = new List<Departure>();
        
        public ActionResult getPartida (int id)
        {
            Partid.Add(new Departure(){ Id = y, IdPlayer = id, estado = false });
            contador++;
            if (contador== 1)
            {
                y = y + 1;
                contador = 0;
            }
            else
            {

            }
            return Json(Partid, JsonRequestBehavior.AllowGet);
        }              
    }
}
