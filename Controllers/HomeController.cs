using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using G8InstaDev.Models;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace G8InstaDev.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        Publicacao feedModel = new Publicacao();
        public IActionResult Index()
<<<<<<< HEAD
        {
            ViewBag.NomeUsuario = HttpContext.Session.GetString("_UserName");
            ViewBag.NomeCompleto = HttpContext.Session.GetString("_NomeCompleto");
=======
        {   
            if (HttpContext.Session.GetString("_IdLogado") == null)
                return LocalRedirect("/Login");
            
            // ViewBag.Usuario = feedModel.Buscar(int.Parse(IdPublicacao));
>>>>>>> 676b8752cf1ffbb537ef530a3fc631226c9e105d
            ViewBag.Feeds = feedModel.ReadAll();
            return View();
        }

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            Publicacao novoFeed = new Publicacao();
            novoFeed.IdPublicacao = feedModel.idPublicacao();

            if (form.Files.Count > 0)
            {
                var file = form.Files[0];
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Feed");

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/", folder, file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    // Salvamos o arquivo no caminho especificado
                    file.CopyTo(stream);
                }

                novoFeed.Imagem = file.FileName;

            }
            else
            {

                novoFeed.Imagem = "padrao.png";
            }

            novoFeed.Legenda = form["Legenda"];
            novoFeed.IdUsuario = int.Parse(HttpContext.Session.GetString("_IdLogado"));
            feedModel.Create(novoFeed);
            ViewBag.Feeds = feedModel.ReadAll();
            return LocalRedirect("~/");

        }
        public IActionResult Excluir(int id)
        {
            feedModel.Delete(id);
            ViewBag.Noticias = feedModel.ReadAll();
            return LocalRedirect("~/");
        }




        // [Route("Editar/{id}/{idusuario}")]
        // public IActionResult Editar(IFormCollection form, int id, int idusuario)
        // {
        //     Publicacao novoFeed = new Publicacao();
        //     novoFeed.IdPublicacao = id;

        //     if (form.Files.Count > 0)
        //     {
        //         var file = form.Files[0];
        //         var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Feed");

        //         if (!Directory.Exists(folder))
        //         {
        //             Directory.CreateDirectory(folder);
        //         }

        //         var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/", folder, file.FileName);
        //         using (var stream = new FileStream(path, FileMode.Create))
        //         {
        //             // Salvamos o arquivo no caminho especificado
        //             file.CopyTo(stream);
        //         }
        //         novoFeed.Imagem = file.FileName;
        //     }
        //     else
        //     {
        //         novoFeed.Imagem = "padrao.png";
        //     }

        //     novoFeed.Legenda = form["Legenda"];

        //     feedModel.Update(novoFeed);
        //     ViewBag.Feeds = feedModel.ReadAll();
        //     return LocalRedirect("~/");
        // }
    }
}
