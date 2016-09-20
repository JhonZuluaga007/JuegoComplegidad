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
        static List<Usuario> Partida = new List<Usuario>();
        static int a;
        static int p;

        public ActionResult GetAgregarUsuario(string Name)
        {
            if (Usuarios.Count == 1)
            {
                Usuarios.Add(new Usuario() { Id = a, Name = Name, partidad = a, Turno = false });
                Partida.Add(new Usuario() { Id = a, Name = Name, partidad = a, Turno = false });
                a++;
                p++;
                var usuario = Usuarios.FirstOrDefault((j) => j.Id == a - 1);
                Usuarios.Clear();
                return Json(usuario, JsonRequestBehavior.AllowGet);
            }
            else
            {
                Usuarios.Add(new Usuario() { Id = a, Name = Name, partidad = a + 1, Turno = true });
                Partida.Add(new Usuario() { Id = a, Name = Name, partidad = a + 1, Turno = true });
                a++;
                p++;
            }
            var usuarios = Usuarios.FirstOrDefault((j) => j.Id == a - 1);
            return Json(usuarios, JsonRequestBehavior.AllowGet);
        }

        public void getChangeTurn(int IdPartidad)
        {
            for (int i = 0; i < Partida.Count; i++)
            {
                if (Partida[i].partidad == IdPartidad)
                {
                    Partida[i].Turno = !Partida[i].Turno;
                }
            }
        }

        public ActionResult getTurn(int Player)
        {
            var Partidas = Partida.FirstOrDefault((j) => j.Id == Player);
            return Json(Partidas, JsonRequestBehavior.AllowGet);
        }

        public ActionResult getConsulta()
        {
            int recibir = p;
            if (recibir == 2)
            {
                p = 0;
                recibir = 0;
            }
            return Json(p, JsonRequestBehavior.AllowGet);
        }
    }
}