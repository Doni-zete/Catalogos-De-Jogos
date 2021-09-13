using Microsoft.AspNetCore.Mvc;
using ApiCategoriaJogos.InputModel;
using ApiCategoriaJogos.ViewModel;
using System;
using System.Threading.Tasks;
using ApiCategoriaJogos.services;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace ApiCategoriaJogos.Controlers.V1
{
    [ApiController]
    [Route("api/[controller]")]
    public class JogosController : ControllerBase
    {

        private readonly IJogoService _jogoService;

        public JogosController(IJogoService jogoService)
        {
            _jogoService = jogoService;
        }



        [HttpGet]


        public async Task<ActionResult<IEnumerable<JogoViewModel>>> Obter([FromQuery, Range(1, int.MaxValue)] int pagina = 1, [FromQuery, Range(1, 50)] int quantidade = 5)
        {
            var jogos = await _jogoService.Obter(pagina, quantidade);

            if (jogos.Count() == 0)
                return NoContent();

            return Ok(jogos);
        }

    }

    [HttpGet("{idJogo:guid}")]
    public async Task<ActionResult<JogoViewModel>> Obter([FromRoute] Guid idJogo)
    {
        var jogo = await _jogoService.Obter(idJogo);

        if (jogo == null)
            return NoContent();

        return Ok(jogo);
    }


    [HttpPost]
    public async Task<ActionResult<jogoViewModel>> InserirJogo([FromBody] jogoViewModel JogoInputModel)
    {
        try
        {
            var jogo = await _jogoService.Inserir(JogoInputModel);
            return Ok(jogo);
        }
       
        catch (Exception ex)
        {
            return UnprocessableEntity("Já existe um jogo com este nome para esta produtora");
        }

    }

    [HttpPut("{idJogo:guid}")]
    public async Task<ActionResult> AtualiazarJogo([FromRoute]Guid idJogo, [FromBody] jogoViewModel jogoInPutModel)
    {
        try
        {
            await _jogoService.Atualizar(idJogo, jogoInPutModel);
            return Ok();
        }

        //catch (JogoNaoCadastradoException ex)
        catch (Exception ex)
        {
            return NotFound("não existe este jogo");
        }
    }

    [HttpPatch("{idJogo:guid}/precp/{precp:double}")]

    public async Task<ActionResult> AtualiazarJogo([FromRoute]Guid idJogo, [FromRoute] double preco)
    {
        try
        {
            await _jogoService.Atualizar(idJogo, preco);
            return Ok();
        }
        //catch(JogoNaoCadastradoException ex)
        catch (Exception ex)
        {
            return NotFound("Ñão existe este jogo");
        }
    }

    [HttpDelete("idJogo:guid)")]

    public async Task<ActionResult> ApagarJogo([FromRoute]Guid idJogo)
    {
        try
        {
            
            await _JogoService.Remover(idJogo);
            return Ok();
        }
        //catch (JogoNaoCadastradoExceprion ex)
        catch (Exception ex)
        {
            return NotFound("Não exite este jogo");
        }

    }

}
}


