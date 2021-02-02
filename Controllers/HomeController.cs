﻿using System;
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
        {
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
            novoFeed.IdUsuario = feedModel.idUsuario();

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
        [Route("Editar/{id}/{idusuario}")]
        public IActionResult Editar(IFormCollection form, int id, int idusuario)
        {
            Feed novoFeed = new Feed();
            novoFeed.IdPublicacao = id;

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
            novoFeed.IdUsuario = idusuario;

            feedModel.Update(novoFeed);
            ViewBag.Feeds = feedModel.ReadAll();
            return LocalRedirect("~/");

        }


    }
}
