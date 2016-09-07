using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Canon.Models
{
    public class Player
    {
        [Key]
        public int Id { get; set; }
        public bool Life { get; set; }
    }
}