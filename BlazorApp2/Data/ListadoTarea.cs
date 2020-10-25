﻿using System;

namespace BlazorApp2.Data
{
    public class ListadoTarea
    {
        public int idTarea { get; set; }
        public string Titulo { get; set; }
        public DateTime Vencimiento { get; set; }
        public int Estimacion { get; set; }        
        public string Estado { get; set; }
        public ListadoTarea() { }

        public ListadoTarea(int idTarea, string titulo, DateTime Vencimiento, int Estimacion,
            string Estado)
        {
            this.idTarea = idTarea;
            Titulo = titulo;
            this.Vencimiento = Vencimiento;
            this.Estimacion = Estimacion;
            this.Estado = Estado;
        }
    }
    
}
