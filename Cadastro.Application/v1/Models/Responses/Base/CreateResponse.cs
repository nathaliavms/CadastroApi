using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Cadastro.Application.v1.Models.Responses.Base
{
    public  abstract class CreateResponse<TResponse> : BaseResponse
    {
        protected CreateResponse()
            : base(StatusCodes.Status201Created, null) 
        { }

        [JsonIgnore]
        public TResponse? Data { get; set; }

        [JsonPropertyName("data")]
        public object? ValueToJson
        {
            get => Data;
        }
    }
}
