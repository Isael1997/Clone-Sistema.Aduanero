using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sistema_Aduanero.Models;
using Microsoft.EntityFrameworkCore;


using System.Data;
using System.Web;


namespace Sistema_Aduanero.Controllers
{
    public class HomeController : Controller
    {
        private DataBAse db = new DataBAse();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Noticias()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult LoginConfirm(string usuario, string contraseña)
        {
            var lista = from datos in db.Clientes select datos;

            if (string.IsNullOrEmpty(usuario) && string.IsNullOrEmpty(contraseña))
            {
                return View(db.Clientes.ToList());
            }
            else
            {
                lista = lista.Where(a => a.Usuario.Equals(usuario));
                lista = lista.Where(a => a.Contraseña.Equals(contraseña));
                return View(lista);
            }
        }






        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
