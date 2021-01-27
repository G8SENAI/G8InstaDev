using G8InstaDev.Models;
using System.Collections.Generic;

namespace G8InstaDev.Interface
{
    public interface ICadastro
    {
        void Create (Cadastro c);
        List<Cadastro> ReadAll();
        void Update(Cadastro c);
        void Delete(int id);
    }
}