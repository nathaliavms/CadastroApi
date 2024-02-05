using Cadastro.Application.v1.Commands;
using Cadastro.Application.v1.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace Cadastro.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    public class CadastroController : ControllerBase
    {
        private readonly ILogger<CadastroController> logger;
        private readonly IMediator mediator;

        public CadastroController(ILogger<CadastroController> logger, IMediator mediator)
        {
            this.logger = logger;
            this.mediator = mediator;
        }

        [HttpGet("{id_pessoa}")]
        public async Task<IActionResult> GetByIdAsync(
            GetPessoaByIdQuery request,
            CancellationToken cancellationToken)
        {

            var response = await mediator.Send(request, cancellationToken);

            return StatusCode(response.StatusCode, response);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(
            CreateCadastroCommand request, 
            CancellationToken cancellationToken)
        {

            var response = await mediator.Send(request, cancellationToken);

            return Ok(response);
        }
    }
}
