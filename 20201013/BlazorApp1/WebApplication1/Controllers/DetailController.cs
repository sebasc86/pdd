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
    public class DetailController : ControllerBase
    {

        private readonly DataContext _context;

        public DetailController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]

        public List<Detail> Get()
        {
            return _context.Details.Include(i => i.Task).Include(i => i.Resource).ToList();

        }


        [HttpGet("{id}")]
        public Detail Get(int id)
        {
            return _context.Details.Where(i => i.Id == id).Include(i => i.Task).Include(i => i.Resource).Single();
        }

        [HttpPost]
        public IActionResult Post(Detail valor)
        {

            /*tiene una cache local si existe esa entidad dentro de la local la desengancha del contexto y agrega la nueva*/
            var local = _context.Details.Local.FirstOrDefault(e => e.Id.Equals(valor.Id));

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


        [HttpDelete("{id}")]
        public async Task<Detail> Delete(int id)
        {


            //var local = _context.Users.Local.FirstOrDefault(e => e.Id.Equals(id));
            var detail = _context.Details.Where(s => s.Id == id).FirstOrDefault();


            if (detail != null)
            {
                _context.Entry(detail).State = EntityState.Detached;
            }


            _context.Entry(detail).State = EntityState.Deleted;



            await _context.SaveChangesAsync();

            return detail;
        }


    }
}
