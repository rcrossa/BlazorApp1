using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Data
{
    public class Usuario
    {

        public int Id { get; set; }
        public string nombre { get; set; }
        public String usuarioid { get; set; }
        public String clave { get; set; }
        [NotMapped]
        public string ClaveInput { get; set; }

    }
}
