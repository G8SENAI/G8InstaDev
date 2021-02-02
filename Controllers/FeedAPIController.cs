using System.Threading.Tasks;
using G8InstaDev.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace G8InstaDev.Controllers
{
    public class FeedAPIController
    {
        [HttpGet("FeedAPI")]
        public List<Feed> List()
        {
            Publicacao feed = new Publicacao();
            return feed.ReadAll();
        }
        [HttpGet("FeedAPI/{id}")]
        public List<Feed> List(int id)
        {
            Feed feed = new Feed();
            return feed.Read(id);
        }
        [HttpPost("FeedAPI")]
        public bool Save([FromBody] Feed f)
        {
            Publicacao feed = new Publicacao();
            feed.Create(f);
            return true;
        }
        [HttpPut("FeedAPI")]
        public bool Edit([FromBody] Feed f)
        {
            Feed feed = new Feed();
            feed.Update(f);
            return true;
        }
        [HttpDelete("FeedAPI/{id}")]
        public bool Delete(int id)
        {
            Feed feed = new Feed();
            feed.Delete(id);
            return true;
        }
    }

}
