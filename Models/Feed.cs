using System.Collections.Generic;
using System.IO;

namespace G8InstaDev.Models
{
    public class Feed : InstaDevBase, IFeed
    {
        public int IdPublicacao { get; set; }
        public string Imagem { get; set; }
        public string Legenda { get; set; }
        
        public int IdUsuario { get; set; }
        
        private const string PATH = "Database/Feed.csv";

        public Feed()
        {
            CreateFolderAndFile(PATH);
        }

        public string Prepare(Feed f){
            return $"{f.IdPublicacao};{f.IdUsuario};{f.Imagem};{f.Legenda}";
        }
        
        public int idPublicacao()
        {
            var publicacoes = ReadAll();

            if(publicacoes.Count == 0)
            {
                return 1;
            }

            var codigo = publicacoes[ publicacoes.Count - 1].IdPublicacao;

            codigo ++;

            return codigo;
        }

        public int idUsuario()
        {
            var usuarios = ReadAll();

            if(usuarios.Count == 0)
            {
                return 1;
            }

            var codigo = usuarios[ usuarios.Count - 1].IdUsuario;

            codigo ++;

            return codigo;
        }
        public void Create(Feed f)
        {
            string[] linhas = {Prepare(f)};
            File.AppendAllLines(PATH, linhas);
        }

        public void Delete(int id)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
            linhas.RemoveAll(x => x.Split(";")[0] == id.ToString());
            RewriteCSV(PATH, linhas);
        }

        public List<Feed> ReadAll()
        {
            List<Feed> feeds = new List<Feed>();
            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
                string[]linha = item.Split(";");

                Feed feed = new Feed();
                feed.IdPublicacao = int.Parse(linha[0]);
                feed.IdUsuario = int.Parse(linha[1]);
                feed.Imagem = linha[2];
                feed.Legenda = linha[3];

                feeds.Add(feed);
            }

            return feeds;
        }

        public void Update(Feed f)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
            linhas.RemoveAll(x => x.Split(";")[0] == f.IdPublicacao.ToString());
            linhas.Add(Prepare(f));
            RewriteCSV(PATH, linhas);   
        }

        public void Alterar(int _id, Feed _novoFeed)
        {
            throw new System.NotImplementedException();
        }
    }
}