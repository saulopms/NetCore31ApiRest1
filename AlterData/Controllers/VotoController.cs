using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AlterData.Models;
using Microsoft.AspNetCore.Http;

namespace AlterData.Controllers
{
    public class VotoController : Controller
    {
        private readonly VotoContext _context;

        public VotoController(VotoContext context)
        {
            _context = context;
        }

        // GET: Voto
        public async Task<IActionResult> Index()
        {
            if (!string.IsNullOrEmpty(
               HttpContext.Session.GetString("usuarioLogadoID")))
                return View(await _context.VwVotos.ToListAsync());
            else
                return RedirectToAction("Logout", "Home");
            
        }

        // GET: Voto/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var voto = await _context.VwVotosLista
                .FirstOrDefaultAsync(m => m.idvoto == id);
            if (voto == null)
            {
                return NotFound();
            }

            return View(voto);
        }

        public async Task<IActionResult> Relatorio()
        {
            if (!string.IsNullOrEmpty(
               HttpContext.Session.GetString("usuarioLogadoID")))
                return View(await _context.VwVotosLista.ToListAsync());
            else
                return RedirectToAction("Logout", "Home");

        }

        // GET: Voto/Create
        public IActionResult Create()
        {
            if (string.IsNullOrEmpty(
              HttpContext.Session.GetString("usuarioLogadoID")))
                return RedirectToAction("Logout", "Home");

            Int32 idfuncionario = 0;

            try
            {
                idfuncionario =
                      Convert.ToInt32(HttpContext.Session.GetString(
                          "usuarioLogadoID"));
            }
            catch
            {

            }

            var voltou = FuncionarioVotou(idfuncionario);

            if (voltou > 0)
            {

                return RedirectToAction("Details",
                    "Voto",new { id = voltou });               
            }
            else
            {
                List<SelectListItem> Lista = new List<SelectListItem>();
                var dados = _context.Recursos.AsNoTracking();
                foreach (var Linha in dados)
                {
                    Lista.Add(new SelectListItem()
                    {
                        Value = Linha.idrecurso.ToString(),
                        Text = Linha.recurso
                    });
                }

                ViewBag.Recursos = Lista;
                return View();
            }


        }

        // POST: Voto/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idvoto,idrecurso,idfuncionario,comentario")] Voto voto)
        {
            
            if (ModelState.IsValid)
            {
                Int32 idfuncionario = 0;

                try
                {
                  idfuncionario =
                        Convert.ToInt32(HttpContext.Session.GetString(
                            "usuarioLogadoID"));
                }
                catch
                {

                }

                if(idfuncionario == 0)
                {
                    return RedirectToAction("Logout", "Home");
                }                
                else
                {
                    var voltou = FuncionarioVotou(idfuncionario);

                    if (voltou > 0)
                    {
                      return RedirectToAction("Details",
                       "Voto", new { id = voltou });
                    }
                    else
                    {

                        var dataatual = DateTime.UtcNow.AddHours(-3);
                        voto.dt_voto = dataatual;
                        voto.hr_voto = dataatual.TimeOfDay;

                        voto.idfuncionario = idfuncionario;

                        _context.Add(voto);
                        await _context.SaveChangesAsync();
                        return RedirectToAction(nameof(Index));
                    }
                }

            }
            return View(voto);
        }



        // GET: Voto/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            var voto = await _context.Votos
             .FirstOrDefaultAsync(m => m.idvoto == id);
            if (voto == null)
            {
                return NotFound();
            }



            return View(voto);
        }

        // POST: Voto/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idvoto,data,hora,idrecurso,idfuncionario")] Voto voto)
        {
            if (id != voto.idvoto)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(voto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VotoExists(voto.idvoto))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(voto);
        }

        // GET: Voto/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var voto = await _context.Votos
                .FirstOrDefaultAsync(m => m.idvoto == id);
            if (voto == null)
            {
                return NotFound();
            }

            return View(voto);
        }

        // POST: Voto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var voto = await _context.Votos.FindAsync(id);
            _context.Votos.Remove(voto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VotoExists(int id)
        {
            return _context.Votos.Any(e => e.idvoto == id);
        }

        private Int32 FuncionarioVotou(int idfuncionario)
        {
            Int32 idvoto = 0;

            var voto = _context.Votos.Where(e => e.idfuncionario ==
                idfuncionario).FirstOrDefault();

            if (voto != null)
                idvoto = voto.idvoto;

            return idvoto;
        }
    }
}
