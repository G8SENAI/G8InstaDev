using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace G8InstaDev.Controllers
{
    [Route("Login")]
    public class LoginController : Controller
    {
        [TempData]
        public string Mensagem { get; set; }
        
        public IActionResult Logar(IFormCollection form)
        {
            List<String> csv = UsuarioModel.ReadAllLinesCSV("Database/usuario.csv");

            var logado = 
            csv.Find(
                x =>
                x.Split(";")[1] == form["Email"] &&
                x.Split(";")[4] == form["Senha"]
            );

            if(logado != null)
            {
                HttpContext.Session.SetString("-UserName", logado.Split(";")[3]);
                return LocalRedirect("~/Feed");
            }

            Mensagem = "Dados incorretos, tente novamente...";
            return LocalRedirect("~/Login");
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}