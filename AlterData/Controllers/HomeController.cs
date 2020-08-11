using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AlterData.Models;
using AlterData.App_Code;
using Microsoft.AspNetCore.Http;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AlterData.Controllers
{
    public class HomeController : ControllerBase
    {
        private readonly VotoContext _context;

        public HomeController(VotoContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public override IActionResult Index()
        {            
            return base.Index();

        }

        [HttpGet]
        public IActionResult Login()
        {
         
            return View();
        }

        [HttpPost]
        public IActionResult Login([FromForm]Funcionario u)
        {
            string senha = "";

            if (!string.IsNullOrEmpty(u.senha))
            {
                senha = cript.Crypt(u.senha);
                var v = _context.Funcionarios.AsNoTracking().Where(
                    a => a.email.Equals(u.email)
                    && a.senha.Equals(senha)).FirstOrDefault();


                if (v != null)
                {
                    HttpContext.Session.SetString("usuarioLogadoID",
                        v.idfuncionario.ToString());
                    HttpContext.Session.SetString("nomeUsuarioLogado",
                        v.funcionario.ToString());
                    return RedirectToAction("Index", "Voto");

                }
                else
                    ViewBag.Mensagem = "Dados incorretos";
            }
            else
                ViewBag.Mensagem = "Informe a senha";

            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.SetString("usuarioLogadoID",
                                    string.Empty);
            HttpContext.Session.SetString("nomeUsuarioLogado",
                string.Empty);
            return RedirectToAction("Login");
        }
    }
}
