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
            Usuario usuario = new Usuario();

            
            var userId = HttpContext.Session.GetInt32("_UserId");

            // var perfil = p.BuscarUsuarioPorId(userId);
            
            ViewBag.perfil = usuario.ReadAll()[0]; // p.BuscarUsuarioPorId(userId);
            return View();
        }

        [Route("Listar")]

        public IActionResult Listar()
        {
            Publicacao publicacao = new Publicacao();
            ViewBag.publicacao = publicacao.ReadAll();
            return View();
        }

        [Route("Sair")]
        public IActionResult Sair()
        {
            HttpContext.Session.Remove("-UserName");
            return LocalRedirect("/Login");
        }
    }
}