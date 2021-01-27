namespace G8InstaDev.Interface
{
    public interface ICadastro
    {
        void Create (Cadastro c);

        List<Jogador> ReadAll();

        void Update(Cadastro c);

        void Delete(int id);
    }
}