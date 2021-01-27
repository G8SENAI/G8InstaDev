using System.Collections.Generic;
using System.IO;

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

        public Cadastro(){
            CreateFolderAndFile(PATH);
        }

        public string Prepare(Cadastro c){
            return $"{c.IdCadastro};{c.Email};{c.NomeCompleto};{c.NomeDoUsuario};{c.Senha};";
        }

        public int idCadastro(){
            var cadastro = ReadAll();

            if (cadastro.Count == 0)
            {
                return 1;
            }

            var codigo = cadastro[cadastro.Count - 1]. IdCadastro;

            codigo ++;

            return codigo;
        }

        public void Create(Cadastro c){
            string[] linhas = {Prepare(cadastro)};
            File.AppendAllLines(PATH, linhas);
        }

        public List<Cadastro> ReadAll(){
            List<Cadastro> cadastro = new List<Cadastro>();
            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
                string[] linha = item.Split(";");

                Cadastro cad = new Cadastro();
                cad.IdCadastro = int.Parse(linha[0]);
                cad.Email = linha[1];
                cad.NomeCompleto = linha[2];
                cad.NomeDoUsuario = linha[3];
                cad.Senha = linha[4];

                cad.Add(cadastro);
            }

            return cadastro;
        }

        public void Update(Cadastro cadastro){
            List<string> linhas = ReadAllLinesCSV(PATH);
            linhas.RemoveAll(x => x.Split(";")[0] == cadastro.IdCadastro.ToString());
            linhas.Add(Prepare(cadastro));
            RewriteCSV(PATH, linhas);
        }

        public void Delete(int id){
            List<string> linhas = ReadAllLinesCSV(PATH);
            linhas.RemoveAll(x => x.Split(";")[0] == id.ToString());
            RewriteCSV(PATH, linhas);
        }
    }
}