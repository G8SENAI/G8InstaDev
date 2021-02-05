using Microsoft.AspNetCore.Mvc;
using G8InstaDev.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Collections.Generic;

namespace G8InstaDev_master.Controllers
{
    [Route("Editar")]
    public class EditarController : Controller
    {
        Usuario editar = new Usuario();


        [Route("Listar")]
        public IActionResult Index()
        {

            ViewBag.Usuario = editar.BuscarUsuarioPorId(int.Parse(HttpContext.Session.GetString("_IdLogado")));

            ViewBag.Editar = editar.ReadAll();
            return View();

        }

        [Route("Cadastrar")]
        public IActionResult Editar(IFormCollection form)
        {
            Usuario usuarioNovo = new Usuario();

            if (form != null)
            {


                if (form.Files.Count > 0)
                {
                    var file = form.Files[0];


                    var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Editar");

                    if (!Directory.Exists(folder))
                    {
                        Directory.CreateDirectory(folder);
                    }

                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Editar/", folder, file.FileName);

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        // Salvamos o arquivo no caminho especificado
                        file.CopyTo(stream);
                    }

                    usuarioNovo.Foto = file.FileName;


                }
            }

            usuarioNovo.IdUsuario = int.Parse(HttpContext.Session.GetString("_IdLogado"));
            usuarioNovo.Email = form["Email"];
            usuarioNovo.NomeCompleto = form["NomeCompleto"];
            usuarioNovo.NomeDoUsuario = form["NomeUsuario"];
            usuarioNovo.Senha = form["Senha"];
            editar.Update(usuarioNovo);
            ViewBag.Editar = editar.ReadAll();
            return LocalRedirect("~/Editar/Listar");
        }

        [Route("{id}")]
        public IActionResult Excluir(int id)
        {
            editar.Delete(id);
            ViewBag.Editar = editar.ReadAll();
            return LocalRedirect("~/Editar/Listar");
        }
        public IActionResult Alterar(Usuario u)
        {
            editar.Update(u);
            return LocalRedirect("~/Editar/Listar");
        }


    }
}