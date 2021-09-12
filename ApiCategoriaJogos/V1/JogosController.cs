using Microsoft.AspNetCore.Mvc;
using ApiCategoriaJogos.InputModel;
using ApiCategoriaJogos.ViewModel;
using System;
using System.Threading.Tasks;
using ApiCategoriaJogos.services;
using System.Collections.Generic;

namespace ApiCategoriaJogos.Controlers.V1
{
    [ApiController]
    [Route("api/[controller]")]
    public class JogosController : ControllerBase
    {

        private readonly IJogoService _JogoService;

       
        


        [HttpGet]
        
            public async Task<ActionResult<List<jogoViewModel>>> Obter()
        {
            var result = await _jogoService.Obter(1, 5);
            return Ok(result);

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

            
