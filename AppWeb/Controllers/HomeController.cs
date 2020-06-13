using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AppWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string nome, string telefone, string email)
        {
            if (nome != null && telefone != null && email != null)
            {
                Models.InsercaoUsuario.InsereUsuario(nome, telefone, email);
            }
            return View();
        }
    }
}
