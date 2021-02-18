using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MinhaAPI.Domain.Commands.Usuario;
using MinhaAPI.Domain.Commands.Usuario.ListarUsuarios;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MinhaAPI.Api.Controllers
{
    public class UsuarioController : Controller
    {

        private readonly IMediator _mediator;

        public UsuarioController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("Versao")]
        public async Task<IActionResult> Versao()
        {
            return Ok(new { Versao = "Minha API v. 1.0.0"});
        }


        [AllowAnonymous]
        [HttpPost]
        [Route("Adicionar")]
        public async Task<IActionResult> Adicionar([FromBody] AdicionarUsuarioRequest request)
        {
            try
            {
                var response = await _mediator.Send(request, CancellationToken.None);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [AllowAnonymous]
        [HttpGet]
        [Route("Listar")]
        public async Task<IActionResult> Listar()
        {
            try
            {
                var request = new ListarUsuarioRequest();
                var response = await _mediator.Send(request, CancellationToken.None);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



    }
}
