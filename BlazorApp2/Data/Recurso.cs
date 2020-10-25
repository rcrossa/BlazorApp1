using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Data
{
    public class Recurso
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string nombre { get; set; }
        public Usuario usuario { get; set; }
        public Recurso() { }

    }
}
