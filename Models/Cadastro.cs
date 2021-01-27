using System.IO;
using System.Collections.Generic;
using G8InstaDev.Interface;

namespace G8InstaDev.Models
{
    public class Cadastro : InstaDevBase , ICadastro
    {
        public int IdCadastro { get; set; }
        public string Email { get; set; }
        public string NomeCompleto { get; set; }
        public string NomeDoUsuario { get; set; }
        public string Senha { get; set; }

        private const string PATH = "Database/Cadastro.csv";

        Cadastro usuario = new Cadastro();

        public void Create(Cadastro c)
        {
            throw new System.NotImplementedException();
        }

        public List<Cadastro> ReadAll()
        {
            throw new System.NotImplementedException();
        }

        public void Update(Cadastro c)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }

}