using ApiCategoriaJogos.InputModel;
using ApiCategoriaJogos.ViewModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiCategoriaJogos.services
{
    public interface IJogoService
    {
        Task<List<jogoViewModel>> Obter(int pagina, int quantidade);
        Task<jogoViewModel> Obter(Guid id);
        Task<JogoInputModel> Inserir(JogoInputModel jogo);
        Task Atualizar(Guid id, JogoInputModel jogo);
        Task Atualizar(Guid id, double preco);
        Task Remover(Guid id);
        
    }
}