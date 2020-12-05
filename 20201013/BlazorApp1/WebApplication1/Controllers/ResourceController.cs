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
    public class ResourceController : ControllerBase
    {

        private readonly DataContext _context;

        public ResourceController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]

        public List<Resource> Get()
        {
            return _context.Resources.Include(i => i.User).ToList(); 
        }
           

        [HttpGet("{id}")]


        public Resource Get(int id)
        {
            return _context.Resources.Where(i => i.Id == id).Include(i => i.User).Single();
        }

        [HttpPost]
        public IActionResult Post(Resource valor)
        {

            /*tiene una cache local si existe esa entidad dentro de la local la desengancha del contexto y agrega la nueva*/
            var local = _context.Resources.Local.FirstOrDefault(e => e.Id.Equals(valor.Id));

            if (local != null)
            {
                _context.Entry(local).State = EntityState.Detached;
            }

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


    }
}
