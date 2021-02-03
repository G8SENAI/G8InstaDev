using G8InstaDev.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace G8InstaDev.Controllers
{
    [Route("Perfil")]
    public class PerfilController : Controller
    {

<<<<<<< HEAD
        public IActionResult Index()
        {
            Usuario usuario = new Usuario();

            
            var userId = HttpContext.Session.GetInt32("_UserId");

            // var perfil = p.BuscarUsuarioPorId(userId);
            
            ViewBag.perfil = usuario.ReadAll()[0]; // p.BuscarUsuarioPorId(userId);
=======
        public IActionResult Index([FromQuery] int idUsuario)
        {
            Usuario usuario = new Usuario();

            var userId = -1;

            if(idUsuario == 0)
            {
                userId = int.Parse(HttpContext.Session.GetString("_IdLogado"));
                
            }else
            {
                userId = idUsuario;
                
            }
            


            Publicacao publicacao = new Publicacao();
            ViewBag.publicacao = publicacao.ReadAll();

            // var perfil = p.BuscarUsuarioPorId(userId);
            
            ViewBag.perfil = usuario.BuscarUsuarioPorId(userId); // p.BuscarUsuarioPorId(userId);
>>>>>>> master
            return View();
        }

        [Route("Listar")]

        public IActionResult Listar()
        {
<<<<<<< HEAD
            Publicacao publicacao = new Publicacao();
            ViewBag.publicacao = publicacao.ReadAll();
=======
            
>>>>>>> master
            return View();
        }

        [Route("Sair")]
        public IActionResult Sair()
        {
<<<<<<< HEAD
            HttpContext.Session.Remove("-UserName");
=======
            HttpContext.Session.Remove("_IdLogado");
>>>>>>> master
            return LocalRedirect("/Login");
        }
    }
}