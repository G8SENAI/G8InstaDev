using System.Threading.Tasks;
using G8InstaDev.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace G8InstaDev.Controllers
{
    public class FeedAPIController
    {
        [HttpGet]
        public List<Feed> listar()
        {
            Feed feed = new Feed();
            return feed.ReadAll();
        }

        [HttpPost]
        public bool Gravar(Feed f)
        {
            Feed feed = new Feed();
            feed.Create(f);
            return true;
        }
    }
}
