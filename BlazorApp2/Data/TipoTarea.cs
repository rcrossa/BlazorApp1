﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace BlazorApp2.Data
{
    public class TipoTarea
    {
        
        public int Id { get; set; }
        public string Tipo { get; set; }
        public int idTipo { get; set; }
    }
}