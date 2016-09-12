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

        static List<Departure> Partid = new List<Departure>();

        public ActionResult getPartida(int Par, int id)
        {
            Partid.Add(new Departure() { Id = Par, IdPlayer = id, estado = false });
            return Json(Partid, JsonRequestBehavior.AllowGet);
        }


        public ActionResult getConsultar()
        {
            return Json(Partid, JsonRequestBehavior.AllowGet);

        }
    }
}
