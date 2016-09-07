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
        public int Id { get; set; }
        public int  IdGamer{ get; set; }
        public int Angle { get; set; }
        public int Power { get; set; }

    }


   
}