using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Cadastro.Application.v1.Models.Responses.Base
{
    public abstract class OkResponse<TResponse> : BaseResponse
    {
        protected OkResponse() 
            : base(StatusCodes.Status200OK, null)
        { }

        [JsonPropertyName("data")]
        public TResponse? Data { get; set; }
    }
}
