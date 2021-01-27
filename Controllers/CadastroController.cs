namespace G8InstaDev.Controllers
{
    [Route("Cadastro")]
    public class CadastroController
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