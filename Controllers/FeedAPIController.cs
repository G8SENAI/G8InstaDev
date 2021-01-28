using System.Threading.Tasks;
using G8InstaDev.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace G8InstaDev.Controllers
{
    public class FeedAPIController
    {
        [HttpGet]
        public List<Publicacao> listar()
        {
            Publicacao feed = new Publicacao();
            return feed.ReadAll();
        }

        [HttpPost]
        public bool Gravar(Publicacao f)
        {
            Publicacao feed = new Publicacao();
            feed.Create(f);
            return true;
        }
    }
}
