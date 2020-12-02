using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using ClassLibrary1.Entidades;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetalleController : ControllerBase
    {
        private readonly TareasDbContext _context;

        public DetalleController(TareasDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Detalle> Get()
        {

            return _context.Detalles.Include(i => i.Recurso).Include(i => i.Tarea).ToList();
        }
        [HttpGet("{id}")]
        public Detalle Get(int id)
        {
            return _context.Detalles.Where(i => i.Id == id).Single();
        }

        [HttpPost]
        public IActionResult Post(Detalle valor)
        {
            var local = _context.Detalles.Local.FirstOrDefault(e => e.Id.Equals(valor.Id));

            if (local != null)
                _context.Entry(local).State = EntityState.Detached;

            if (valor.Id == 0)
            {
                _context.Entry(valor).State = EntityState.Added;
            }
            else
            {
                _context.Entry(valor).State = EntityState.Modified;
            }
            _context.SaveChanges();
            return Ok(valor);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodoItem(int id)
        {
            var todoItem = await _context.Detalles.FindAsync(id);

            if (todoItem == null)
            {
                return NotFound();
            }

            _context.Detalles.Remove(todoItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
