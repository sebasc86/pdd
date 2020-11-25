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
            /*return _context.Details.ToList();*/

        }

    }
}
