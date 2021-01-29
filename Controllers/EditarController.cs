using Microsoft.AspNetCore.Mvc;
using G8InstaDev.Models;

namespace G8InstaDev_master.Controllers
{
    [Route("Editar")]
    public class EditarController : Controller
    {
        Usuario editar = new Usuario();


        public IActionResult Index(){
            ViewBag.Editar = editar.ReadAll(); 
            return View();
        }
        public IActionResult Alterar(){
            
            return View();
        }

    [Route("{id}")]
        public IActionResult Excluir(int id){
            editar.Delete(id);
            ViewBag.Editar = editar.ReadAll();
            return LocalRedirect("~/Editar/Listar");
        }

    }   
}