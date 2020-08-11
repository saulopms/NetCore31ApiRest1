using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AlterData.Models;
using AlterData.App_Code;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AlterData.Controllers
{
    [Route("api/[controller]")]
    public class AFuncionarioController : Controller
    {
        private readonly VotoContext _context;

        public AFuncionarioController(VotoContext context)
        {
            _context = context;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Funcionario> Get()
        {
            return _context.Funcionarios.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Funcionario Get(int id)
        {
            return _context.Funcionarios.Where(x => x.idfuncionario ==
            id).FirstOrDefault();
        }

        // POST api/values
        [HttpPost]        
        public IActionResult Create([FromBody] Funcionario obj)
        {
            if (obj == null)
            {
                return BadRequest();
            }
            obj.senha = cript.Crypt(obj.senha);

            _context.Add(obj);
            _context.SaveChangesAsync();

           return CreatedAtAction(
           nameof(Get),
           new { id = obj.idfuncionario },
           obj);
          
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Funcionario obj)
        {
            //criptografar nova senha
            var funcionarioAnt =  _context.Funcionarios.AsNoTracking()
                      .Where(m => m.idfuncionario == id).FirstOrDefault();

            if(funcionarioAnt != null)
            {
                if (obj.senha != funcionarioAnt.senha)
                {
                    if (!string.IsNullOrEmpty(obj.senha))
                        obj.senha =
                            cript.Crypt(obj.senha);
                    else
                        obj.senha = funcionarioAnt.senha;
                }

                obj.idfuncionario = id;

                _context.Update(obj);
                _context.SaveChangesAsync();
            }
            




        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var funcionario =
                _context.Funcionarios.Where(x => x.idfuncionario == id).FirstOrDefault();
            _context.Funcionarios.Remove(funcionario);
            _context.SaveChangesAsync();
            
        }
    }
}
