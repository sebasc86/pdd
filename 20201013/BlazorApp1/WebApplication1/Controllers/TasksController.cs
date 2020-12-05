using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClassLibrary1.Entidades;
using WebApplication1.Data;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly DataContext _context;

        public TasksController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]

        public List<Tasks> Get()
        {
            return _context.Tasks.Include(i => i.Resource).ToList();
        }

        [HttpGet("{id}")]


        public Tasks Get(int id)
        {
            return _context.Tasks.Where(i => i.Id == id).Include(i => i.Resource).Single();
        }


        [HttpPost]
        public IActionResult Post(Tasks valor)
        {

            /*tiene una cache local si existe esa entidad dentro de la local la desengancha del contexto y agrega la nueva*/
            var local = _context.Tasks.Local.FirstOrDefault(e => e.Id.Equals(valor.Id));

            if(local != null)
            {
                _context.Entry(local).State = EntityState.Detached;
            }

            if (valor.Id == 0)
            {
                _context.Entry(valor).State = EntityState.Added;
            } else
            {
                _context.Entry(valor).State = EntityState.Modified;
            }
            _context.SaveChanges();
            return Ok(valor);


        }

        [HttpDelete("{id}")]
        public async Task<Tasks> Delete(int id)
        {


            //var local = _context.Users.Local.FirstOrDefault(e => e.Id.Equals(id));
            var task = _context.Tasks.Where(s => s.Id == id).FirstOrDefault();


            if (task != null)
            {
                _context.Entry(task).State = EntityState.Detached;
            }


            _context.Entry(task).State = EntityState.Deleted;



            await _context.SaveChangesAsync();

            return task;
        }
    }
}
