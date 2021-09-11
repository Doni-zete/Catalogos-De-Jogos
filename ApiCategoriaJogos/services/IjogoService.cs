namespace ApiCategoriaJogos.services
{
    public interface IjogoService
    {
        Task<List<jogoViewModel>> Obter(int pagina, int quantidade);
        Task<jogoViewModel> Obter (Guid id);
        Task<JogoInputModel> Inserir(JogoInputModel jogo);
        Task Atualizar(Guid id, JogoInputModel jogo);
        Task Atualizar(Guid id, double preco);
        Task Remover(Guid id);
        
    }
}