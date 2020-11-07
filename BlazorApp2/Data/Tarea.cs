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

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int TipoId { get; set; }
        public TipoTarea Tipo { get; set; }
    }
}
