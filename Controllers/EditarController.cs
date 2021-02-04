using Microsoft.AspNetCore.Mvc;
using G8InstaDev.Models;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace G8InstaDev_master.Controllers
{
    [Route("Editar")]
    public class EditarController : Controller
    {
        Usuario editar = new Usuario();


        [Route("Listar")]
        public IActionResult Index(){
            ViewBag.Editar = editar.ReadAll(); 
            return View();
            
        }

        [Route("Cadastrar")]
        public IActionResult Editar(IFormCollection form)
        {
            Usuario usuarioNovo = new Usuario();
            
            if(form.Files.Count > 0)
            {
                var file = form.Files[0];
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Editar");

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

                usuarioNovo.Foto = "padrao.png";

                }

            usuarioNovo.Email = form["Email"];
            usuarioNovo.NomeCompleto = form["NomeCompleto"];
            usuarioNovo.NomeDoUsuario = form["NomeUsuario"];

            editar.Create(usuarioNovo);
            ViewBag.Editar = editar.ReadAll();
            return LocalRedirect("~/Editar");
        }

        [Route("{id}")]
        public IActionResult Excluir(int id){
            editar.Delete(id);
            ViewBag.Editar = editar.ReadAll();
            return LocalRedirect("~/Editar/Listar");
        }

    }   
}