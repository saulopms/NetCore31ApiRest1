using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AlterData.Models;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AlterData.Controllers
{
    [Route("api/[controller]")]
    public class ARecursoController : Controller
    {
        private readonly VotoContext _context;

        public ARecursoController(VotoContext context)
        {
            _context = context;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Recurso> Get()
        {
            return _context.Recursos.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Recurso Get(int id)
        {
            return _context.Recursos.Where(x => x.idrecurso ==
            id).FirstOrDefault();
        }

        // POST api/values
        [HttpPost]
        public IActionResult Create([FromBody] Recurso obj)
        {
            if (obj == null)
            {
                return BadRequest();
            }
            _context.Add(obj);
            _context.SaveChangesAsync();
            return CreatedAtAction(
            nameof(Get),
            new { id = obj.idrecurso },
            obj);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Recurso obj)
        {
            //criptografar nova senha
            var recursoAnt = _context.Recursos.AsNoTracking()
                      .Where(m => m.idrecurso == id).FirstOrDefault();

            if (recursoAnt != null)
            {
               
                obj.idrecurso = id;

                _context.Update(obj);
                _context.SaveChangesAsync();
            }
            




        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var objrecurso = _context.Recursos.Where(x => x.idrecurso == id).FirstOrDefault();
            _context.Recursos.Remove(objrecurso);
            _context.SaveChangesAsync();
           
        }
    }
}
