using Cadastro.Domain.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Cadastro.Application.v1.Models.Requests
{
    public class CreateCadastroRequest 
    {
        [JsonPropertyName("id_pessoa")]
        public Guid? Id { get; set; }

        [JsonPropertyName("nome_pessoa")]
        public string? Name { get; set; }

    }
}
