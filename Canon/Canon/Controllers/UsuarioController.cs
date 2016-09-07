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
    public class UsuarioController : Controller
    {
        Usuario[] Usuarios = new Usuario[]
        {
        new Usuario {Id=1, Name="player1", Estado= false},
        new Usuario {Id=2, Name="player2", Estado= false},
        new Usuario {Id=3, Name="player3", Estado= false}
        };

        public ActionResult GetAllUsuario()
        {
            return Json(Usuarios, JsonRequestBehavior.AllowGet);
        }
        public ActionResult getUsuario(int id)
        {
            var usuarios = Usuarios.FirstOrDefault((c) => c.Id == id);
            return Json(usuarios, JsonRequestBehavior.AllowGet);
        }
    }
}