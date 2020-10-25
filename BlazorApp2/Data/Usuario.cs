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
        [Key]//es una anotation para que entity entienda cual es la primary key
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [MaxLength(50)]
        [MinLength(10)]
        public string nombre { get; set; }
        public String usuarioid { get; set; }
        public String clave { get; set; }


    }
}
