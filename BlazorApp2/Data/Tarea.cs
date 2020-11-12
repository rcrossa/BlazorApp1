using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Data
{
    public class Tarea
    {

        
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string TipoId { get; set; }
        public TipoTarea idTipo { get; set; }
    }
}
