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
    public class UsuarioController : ControllerBase
    {
        private readonly TareasDbContext _context;

        public UsuarioController(TareasDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Usuario> Get()
        {
            return _context.Usuarios.ToList();
        }
        [HttpGet("{id}")]
        public Usuario get(int id)
        {
            return _context.Usuarios.Where(i => i.UsuarioPK == id).Single();
        }
        [HttpPost]
        public IActionResult Post(Usuario valor)
        {
            var local = _context.Usuarios.Local.FirstOrDefault(e => e.UsuarioPK.Equals(valor.UsuarioPK));

            if (local != null)
                _context.Entry(local).State = EntityState.Detached;

            if (valor.UsuarioPK == 0)
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
            var todoItem = await _context.Usuarios.FindAsync(id);

            if (todoItem == null)
            {
                return NotFound();
            }

            _context.Usuarios.Remove(todoItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
    }

