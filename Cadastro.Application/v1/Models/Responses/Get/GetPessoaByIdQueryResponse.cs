using Cadastro.Application.v1.Models.Responses.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Application.v1.Models.Responses.Get
{
    public sealed class GetPessoaByIdQueryResponse
        : OkResponse<PessoaResponse>
    {
    }
}
