using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AlterData.Models;
using AlterData.App_Code;
using Microsoft.AspNetCore.Http;



namespace AlterData.Controllers
{
    public class ControllerBase: Controller
    {
      

        public virtual IActionResult Index()
        {
            if (HttpContext.Session.GetString("usuarioLogadoID") != null)
                return View();
            else
                return RedirectToAction("Login");
        }

     
    }
}
