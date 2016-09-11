using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Canon.Models
{
    public class Departure
    {
        [Key]
        public int Id { get; set; }
        public int IdPlayer { get; set; }
        public bool estado { get; set; }
    }

}