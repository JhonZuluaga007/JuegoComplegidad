using Canon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using System.Xml.Linq;

namespace Canon.Controllers
{
    public class UsuarioController : Controller
    {
        static List<Usuario> Usuarios = new List<Usuario>();
        

    

        public ActionResult GetAllUsuario()
        {
            Usuarios.Add(new Usuario() { Id = 1, Name = "player1", Estado = false });
            Usuarios.Add(new Usuario() { Id = 2, Name = "player1", Estado = false });
            return Json(Usuarios, JsonRequestBehavior.AllowGet);
        }
        public ActionResult getUsuario(int id)
        {
            var usuarios = Usuarios.FirstOrDefault((c) => c.Id == id);
            return Json(usuarios, JsonRequestBehavior.AllowGet);
            
        }


      


        }
    }
