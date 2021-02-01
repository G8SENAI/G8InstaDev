using G8InstaDev.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace G8InstaDev.Controllers
{
    [Route("Perfil")]
    public class PerfilController : Controller
    {

        public IActionResult Index()
        {
            Usuario perfil = new Usuario();

            
            
            perfil.Foto = "~/img/Perfil/thank-you 3.png";
            perfil.NomeCompleto = "Marcos Jeeves";
            perfil.NomeDoUsuario = "yes_baby";
            ViewBag.perfil = perfil;
            return View();
        }

        [Route("Listar")]

        public IActionResult Listar()
        {
            Publicacao publicacao = new Publicacao();
            ViewBag.publicacao = publicacao.ReadAll();
            return View();
        }
    }
}