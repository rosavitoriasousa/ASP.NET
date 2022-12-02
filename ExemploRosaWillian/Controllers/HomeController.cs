using ExemploRosaWillian.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExemploRosaWillian.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Usuario()
        {
            var usuario = new Usuario1(); // criando um objeto para a classe,todos os arquivos devem estar na pasta HOME!

            return View(usuario); // retorna para view os dados do usuario
        }

        [HttpPost]

        public ActionResult Usuario(Usuario1 usuario)
        {
            if (ModelState.IsValid) // validando o estado ou seja verificando a requisição
            {
                return View("Resultado", usuario); // retorna para a view usuario
            }
            return View(usuario);
        }
        public ActionResult Resultado(Usuario1 usuario) // retorna para a view usuario
        {
            return View(usuario);
        }
        
    }
}