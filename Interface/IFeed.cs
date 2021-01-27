using System.Collections.Generic;
using G8InstaDev.Models;

namespace G8InstaDev
{
    public interface IFeed
    {
         void Create (Feed f);
         List<Feed> ReadAll();
         void Update(Feed f);
         void Delete(int id);
         void Alterar(int _id, Feed _novoFeed);
    }
}