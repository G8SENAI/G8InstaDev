using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using G8InstaDev.Models;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace G8InstaDev.Controllers
{
    [Route("Cadastro")]
    public class CadastroController : Controller
    {
        Usuario usuarioModel = new Usuario();
        [Route("Listar")]
        public IActionResult Index(){
            ViewBag.Cadastro = usuarioModel.ReadAll();

            Usuario novalistagemdeusuario = new Usuario();
            ViewBag.novalistagemdeusuario = novalistagemdeusuario.ReadAll();
            return View();
        }

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection formCadastro){
            Usuario cadastrar = new Usuario();
            cadastrar.IdUsuario = usuarioModel.idCadastro();
            cadastrar.Email = formCadastro["Email"];
            cadastrar.NomeCompleto = formCadastro["Nome Completo"];
            cadastrar.NomeDoUsuario = formCadastro["Nome do usuário"];
            cadastrar.Senha = formCadastro["Senha"];

            usuarioModel.Create(cadastrar);
            ViewBag.Cadastro = usuarioModel.ReadAll();
            return LocalRedirect("~/Cadastro/Listar");
        }
    }
}