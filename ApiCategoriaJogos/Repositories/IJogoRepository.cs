using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiCategoriaJogos.Repositories
{
    public interface IJogoRepository
    {
        Task<List<Jogo>> Obter(int pagina, int quantidade);
        Task<Jogo> Obter(Guid id);
        Task<List<Jogo>> Obter(string nome, string produtora);
        Task Inserir(Jogo jogo);
        Task Atuzalizar(Jogo jogo);
        Task Remover(Guid id);

    }
}