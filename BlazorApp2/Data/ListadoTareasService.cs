using System;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Data
{
    public class ListadoTareasService
    {
        public ListadoTarea[] GetListadoTareas()
        {
            ListadoTarea[] Resultado = new ListadoTarea[5];
            Resultado[0] = new ListadoTarea(1,"Primer Tarea",DateTime.Now,10,"ok");
            Resultado[1] = new ListadoTarea(2, "Segunda Tarea", DateTime.Now, 8, "ok");
            Resultado[2] = new ListadoTarea(3, "Tercera Tarea", DateTime.Now, 7, "ok");
            Resultado[3] = new ListadoTarea(4, "Cuarta Tarea", DateTime.Now, 6, "ok");
            Resultado[4] = new ListadoTarea(5, "Quinta Tarea", DateTime.Now, 9, "ok");
            return Resultado;
        }
    }
}
