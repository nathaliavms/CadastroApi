using System.Text.Json.Serialization;

namespace Cadastro.Application.v1.Models.Responses.Base
{
    public abstract class BaseResponse
    {
        protected BaseResponse() { }

        protected BaseResponse(int statusCode,
            ICollection<MensagemResponse>? mensagens) 
        {
            StatusCode = statusCode;
            Mensagens = mensagens;
        }

        [JsonIgnore]
        public int StatusCode { get;}

        [JsonPropertyName("mensagens")]
        public ICollection<MensagemResponse>? Mensagens { get; }
    }
}
