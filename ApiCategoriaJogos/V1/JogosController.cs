using Microsoft.AspNetCore.Mvc;
using ApiCategoriaJogos.InputModel;
using ApiCategoriaJogos.ViewModel;
using System;
using System Collections.Generic;
using System.Threading.Tasks;


namespace ApiCategoriaJogos.Controlers.V1
{
    [ApiController]
    [Route("api/[controller]")]
    public class JogosController : ControllerBase
    {

        [HttpGet]
        {
            public async Task<ActionResult<List<jogoViewModel>>> Obter()
            {
                return Ok();

            }

            [HttpGet("{idJogo:guid}")]
        
            public async Task<ActionResult<jogoViewModel>> Obter(Guid idJogo)


            [HttpPost]
        
            public async Task<ActionResult<jogoViewModel>> InserirJogo( object jogo)
            {
                return Ok();

            }

            [HttpPut("{idJogo:guid}")]
            public async Task<ActionResult> AtualiazarJogo(Guid idJogo, object jogo)
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
            
