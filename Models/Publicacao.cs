using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace G8InstaDev.Models
{
    public class Publicacao : InstaDevBase, IPublicacao
    {
        public int IdPublicacao { get; set; }
        public string Imagem { get; set; }
        public string Legenda { get; set; }
        public int IdUsuario { get; set; }

        private const string PATH = "Database/Feed.csv";

        Usuario usuarioModel = new Usuario();

        public Publicacao()
        {
            CreateFolderAndFile(PATH);
        }

        public string Prepare(Publicacao p)
        {
            return $"{p.IdPublicacao};{p.Imagem};{p.Legenda};{p.IdUsuario}";
        }

        public int idPublicacao()
        {
            var publicacoes = ReadAll();

            if (publicacoes.Count == 0)
            {
                return 1;
            }

            var codigo = publicacoes[publicacoes.Count - 1].IdPublicacao;

            codigo++;

            return codigo;
        }
        public void Create(Publicacao p)
        {
            string[] linhas = { Prepare(p) };
            File.AppendAllLines(PATH, linhas);
        }

        public void Delete(int id)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
            linhas.RemoveAll(x => x.Split(";")[0] == id.ToString());
            RewriteCSV(PATH, linhas);
        }

        public List<Publicacao> ReadAll()
        {
            List<Publicacao> feeds = new List<Publicacao>();
            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
                string[] linha = item.Split(";");

                Publicacao publicacao = new Publicacao();
                publicacao.IdPublicacao = int.Parse(linha[0]);
                publicacao.Imagem = linha[1];
                publicacao.Legenda = linha[2];
                publicacao.IdUsuario = int.Parse(linha[3]);

                feeds.Add(publicacao);
            }

            return feeds;
        }

        public void Update(Publicacao p)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
            linhas.RemoveAll(x => x.Split(";")[0] == p.IdPublicacao.ToString());
            linhas.Add(Prepare(p));
            RewriteCSV(PATH, linhas);
        }

        public Usuario Buscar(int id)
        {

            List<String> csv = usuarioModel.ReadAllLinesCSV("Database/Usuario.csv");

            var linhaBuscada =
            csv.Find(
                x =>
                x.Split(";")[0] == id.ToString()
            );

            var usuarioLinha = linhaBuscada.Split(";");
            Usuario usuarioBuscado = new Usuario();
            usuarioBuscado.Foto = usuarioLinha[6].ToString();
            usuarioBuscado.NomeDoUsuario = usuarioLinha[3].ToString();
            return usuarioBuscado;
        }
    }
}