using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Data
{
    public class Detalle
    {
      [Key]
        public string Fecha { get; set; }
        public string Tiempo { get; set; }
        public Recurso Recurso { get; set; }
        public Tarea Tarea { get; set; }
    }
}
