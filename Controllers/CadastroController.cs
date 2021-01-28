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
        Cadastro cadastroModel = new Cadastro();
        [Route("Listar")]
        public IActionResult Index(){
            ViewBag.Cadastro = cadastroModel.ReadAll();

            Cadastro novalistagemdecadastro = new Cadastro();
            ViewBag.novalistagemdecadastro = novalistagemdecadastro.ReadAll();
            return View();
        }

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection formCadastro){
            Cadastro cadastrar = new Cadastro();
            cadastrar.IdCadastro = cadastroModel.idCadastro();
            cadastrar.Email = formCadastro["Email"];
            cadastrar.NomeCompleto = formCadastro["Nome Completo"];
            cadastrar.NomeDoUsuario = formCadastro["Nome do usuário"];
            cadastrar.Senha = formCadastro["Senha"];

            cadastroModel.Create(cadastrar);
            ViewBag.Cadastro = cadastroModel.ReadAll();
            return LocalRedirect("~/Cadastro/Listar");
        }
    }
}