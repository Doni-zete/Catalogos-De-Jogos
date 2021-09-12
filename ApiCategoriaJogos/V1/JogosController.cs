using Microsoft.AspNetCore.Mvc;
using ApiCategoriaJogos.InputModel;
using ApiCategoriaJogos.ViewModel;
using System;
using System.Threading.Tasks;
using ApiCategoriaJogos.services;
using System.Collections.Generic;
using System.Linq;

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
    public async Task<ActionResult<jogoViewModel>> Obter(Guid idJogo);


    [HttpPost]
    public async Task<ActionResult<jogoViewModel>> InserirJogo(jogoViewModel jogo)
    {
        return Ok();

    }

    [HttpPut("{idJogo:guid}")]
    public async Task<ActionResult> AtualiazarJogo(Guid idJogo, jogoViewModel jogo)
    {
        return Ok();
    }

    [HttpPatch("{idJogo:guid}/precp/{precp:double}")]

    public async Task<ActionResult> AtualiazarJogo(Guid idJogo, double preco)
    {
        return Ok();
    }

    [HttpDelete("idJogo:guid)")]

    public async Task<ActionResult> ApagarJogo(Guid idJogo)
    {
        return Ok();

    }

}
}


