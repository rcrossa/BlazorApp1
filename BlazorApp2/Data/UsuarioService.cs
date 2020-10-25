using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Data
{
    public class UsuarioService
    {
        static void Actualizar()
        {
            var ctx = new DataContext();
            var lista = ctx.Usuarios.Where(i => i.Id == 1).ToList();
            lista[0].nombre = "Roberto Rossa";
            ctx.SaveChanges();
        }
        static void Consultar()
        {
            var ctx = new DataContext();
            var lista = ctx.Usuarios.ToList();
            foreach (var item in lista)
            {
                Console.WriteLine($"Nombre: {item.nombre} ({item.Id})");
            }
        }
        static void Insertar()
        {
            var ctx = new DataContext();
            ctx.Usuarios.Add(new Usuario
            {
                Id = 3,
                nombre = "PEPE Rodriguez",
                clave = "1234",
                usuarioid = "Test"

            });

            ctx.SaveChanges();
        }

        static void borrar()
        {
            var ctx = new DataContext();

        }

        private DataContext context;

        public UsuarioService(DataContext _context) {

            context = _context;
        }
        public async Task<List<Usuario>> GetAll()
        {
            return await context.Usuarios.ToListAsync();
        }
    }
}
