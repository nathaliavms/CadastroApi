using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Application.v1.Queries
{
    public class GetPessoaByIdQuery 
    {
        [FromRoute(Name = "id_pessoa")]
        public Guid? Id { get; set; }
    }
}
