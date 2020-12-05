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
    public class UserController : ControllerBase
    {

        private readonly DataContext _context;

        public UserController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]

        public List<User> Get()
        {

            return _context.Users.ToList();

        }

        [HttpGet("{id}")]
        public User Get(int id)
        {
            return _context.Users.Where(i => i.Id == id).Single();
        }

        [HttpPost]
        public User Post(User valor)
        {

            /*tiene una cache local si existe esa entidad dentro de la local la desengancha del contexto y agrega la nueva*/
            var local = _context.Users.Local.FirstOrDefault(e => e.Id.Equals(valor.Id));

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
            return valor;


        }

        [HttpDelete("{id}")]
        public User Delete(int id)
        {

            /*tiene una cache local si existe esa entidad dentro de la local la desengancha del contexto y agrega la nueva*/
            //var local = _context.Users.Local.FirstOrDefault(e => e.Id.Equals(id));
            var user = _context.Users.Where(s => s.Id == id).FirstOrDefault();
            _context.Entry(user).State = EntityState.Deleted;

            _context.SaveChanges();

            return user;
        }

    }
}
