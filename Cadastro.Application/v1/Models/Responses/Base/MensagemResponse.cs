using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Cadastro.Application.v1.Models.Responses.Base
{
    public sealed class MensagemResponse
    {
        [JsonPropertyName("codigo")]
        public string? Code {  get; set; }

        [JsonPropertyName("mensagem")]
        public string? Mensagem { get; set; }

        [JsonPropertyName("tipo")]
        public TipoMensagemResponse Tipo { get; set; }

        [JsonPropertyName("campos")]
        public ICollection<CampoMensagemResponse>? Campos { get; set; }
    }
    public sealed class CampoMensagemResponse
    {
        [JsonPropertyName("campo")]
        public string? Campo { get; set; }

        [JsonPropertyName("valor")]
        public string? Valpr { get; set; }

        [JsonPropertyName("mensagem")]
        public string? Mensagem { get; set; }

    }
        public enum TipoMensagemResponse
    {
        Warning,
        Error,
        Fatal,
        Critical
    }
}
