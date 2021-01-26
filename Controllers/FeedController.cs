using System;
using System.IO;
using G8InstaDev.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace G8InstaDev.Controllers
{
    [Route("Feed")]
    public class FeedController : Controller
    {
        Feed feedModel = new Feed();
        [Route("Listar")]

        public IActionResult Index()
        {
            ViewBag.Feeds = feedModel.ReadAll();
            return View();
        }

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            Feed novoFeed = new Feed();
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
            novoFeed.IdUsuario = feedModel.idUsuario();
            novoFeed.Likes = Int32.Parse(form["Likes"]);

            feedModel.Create(novoFeed);
            ViewBag.Noticias = feedModel.ReadAll();
            return LocalRedirect("~/Feed/Listar");

        }

        [Route("{id}")]
        public IActionResult Excluir(int id)
        {
            feedModel.Delete(id);
            ViewBag.Noticias = feedModel.ReadAll();
            return LocalRedirect("~/Feed/Listar");
        }
    }
}