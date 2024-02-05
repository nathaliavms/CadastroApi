using AutoMapper;
using Cadastro.Application.v1.Models.Requests;
using Cadastro.Application.v1.Models.Responses.Create;
using Cadastro.Application.v1.Models.Responses.Get;
using Cadastro.Domain.Entities;

namespace Cadastro.Application.v1.Mappers
{
    public class PessoaMapper : Profile
    {
        public PessoaMapper() 
        {
            // request -> domain
            _ = CreateMap<CreateCadastroRequest, Pessoa>()
                .ForMember(dest => dest.Id, opts => opts.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.Name));

            // domain -> wrapper response
            _ = CreateMap<Pessoa, CreatePessoaCommandResponse>()
                .ForMember(dest => dest.Data, opts => opts.MapFrom(src => src))
                .ForMember(dest => dest.Mensagens, opts => opts.MapFrom(src => src));

            // domain -> wrapper response
            _ = CreateMap<Pessoa, GetPessoaByIdQueryResponse>()
                .ForMember(dest => dest.Data, opts => opts.MapFrom(src => src))
                .ForMember(dest => dest.Mensagens, opts => opts.MapFrom(src => src));
        }
    }
}
