﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Canon.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int partidad { get; set; }
        public bool  Turno { get; set; }

    }
}