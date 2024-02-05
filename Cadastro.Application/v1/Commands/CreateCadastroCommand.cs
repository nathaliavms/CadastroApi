using Cadastro.Application.v1.Models.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Cadastro.Application.v1.Commands
{
    public class CreateCadastroCommand 
    {
        [FromBody]
        public CreateCadastroRequest? Paylod { get; set; }
    }
}
