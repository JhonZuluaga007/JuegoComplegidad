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
         
          static int a;


        public ActionResult GetAgregarUsuario(string Name)
        {
            if (Usuarios.Count == 2)
            {
               Usuarios.Add(new Usuario() { Id = a, Name = Name, Estado = false});
               
                DepartureController partidad = new DepartureController();
                partidad.getPartida(a,Usuarios[1].Id);
                partidad.getPartida(a,Usuarios[0].Id);
                Usuarios.RemoveAt(1);
                Usuarios.RemoveAt(0);

                a++;
                


            }
            else
            {
               Usuarios.Add(new Usuario() { Id = a, Name = Name, Estado = true });
               a++;
            }

            var usuarios = Usuarios.FirstOrDefault((j) => j.Id==a-1 );
            return Json(usuarios, JsonRequestBehavior.AllowGet);



        }
        public ActionResult getUsuario(String name)
        {
            LauchingController ad=  new LauchingController();
         
          
             var usuarios = Usuarios.FirstOrDefault((j) => j.Name == name);
                return Json(usuarios.Id, JsonRequestBehavior.AllowGet);
            }
            
        }


        


      


        }
    
