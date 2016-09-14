using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Canon.Models
{
    public class Launching
    {
        [Key]
        public int Departure { get; set; }
        public int IdGamer { get; set; }
        public bool IdTurno { get; set; }
        public float Velocidad { get; set; }
        public float Angle { get; set; }
    }
}