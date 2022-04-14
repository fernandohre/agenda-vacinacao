using AutoMapper;
using Vacinacao.Core.Domain;
using Vacinacao.Core.Domain.Dto;

namespace Vacinacao.Core.AutoMapper
{
    public class DtoEntity : Profile
    {
        public DtoEntity() 
        {
            CreateMapDtoToEntity();
            CreateMapEntityToDto();
        }

        private void CreateMapDtoToEntity() 
        {
            CreateMap<AlergiaDto, Alergia>()
                .ForMember(x => x.Nome, opts => opts.MapFrom(x => x.Nome))
                .ForMember(x => x.Id, opts => opts.Ignore());

            CreateMap<AgendaDto, Agenda>()
                .ForMember(x => x.Situacao, opts => opts.MapFrom(x => x.Situacao))
                .ForMember(x => x.DataSituacao, opts => opts.MapFrom(x => x.DataSituacao))
                .ForMember(x => x.Hora, opts => opts.MapFrom(x => x.Hora))
                .ForMember(x => x.Observacoes, opts => opts.MapFrom(x => x.Observacoes))
                .ForMember(x => x.Data, opts => opts.MapFrom(x => x.Data))
                .ForMember(x => x.Id, opts => opts.Ignore())
                .ForMember(x => x.Vacina, opts => opts.Ignore());

            CreateMap<UsuarioDto, Usuario>()
                .ForMember(x => x.Alergias, opts => opts.Ignore())
                .ForMember(x => x.Nome, opts => opts.MapFrom(x => x.Nome))
                .ForMember(x => x.Setor, opts => opts.MapFrom(x => x.Setor))
                .ForMember(x => x.Sexo, opts => opts.MapFrom(x => x.Sexo))
                .ForMember(x => x.Uf, opts => opts.MapFrom(x => x.Uf))
                .ForMember(x => x.Cidade, opts => opts.MapFrom(x => x.Cidade))
                .ForMember(x => x.Logradouro, opts => opts.MapFrom(x => x.Logradouro))
                .ForMember(x => x.DataNascimento, opts => opts.MapFrom(x => x.DataNascimento))
                .ForMember(x => x.Numero, opts => opts.MapFrom(x => x.Numero))
                .ForMember(x => x.Id, opts => opts.Ignore());

            CreateMap<VacinaDto, Vacina>()
                .ForMember(x => x.Titulo, opts => opts.MapFrom(x => x.Titulo))
                .ForMember(x => x.Descricao, opts => opts.MapFrom(x => x.Descricao))
                .ForMember(x => x.Doses, opts => opts.MapFrom(x => x.Doses))
                .ForMember(x => x.Peridiocidade, opts => opts.MapFrom(x => x.Peridiocidade))
                .ForMember(x => x.Agendas, opts => opts.Ignore())
                .ForMember(x => x.Intervalo, opts => opts.MapFrom(x => x.Intervalo))
                .ForMember(x => x.Id, opts => opts.Ignore());
        }

        private void CreateMapEntityToDto() 
        {
            CreateMap<Alergia, AlergiaDto>()
                .ForMember(x => x.Id, opts => opts.MapFrom(x => x.Id))
                .ForMember(x => x.Nome, opts => opts.MapFrom(x => x.Nome));

            CreateMap<Vacina, VacinaDto>()
                .ForMember(x => x.Id, opts => opts.MapFrom(x => x.Id))
                .ForMember(x => x.Titulo, opts => opts.MapFrom(x => x.Titulo))
                .ForMember(x => x.Descricao, opts => opts.MapFrom(x => x.Descricao))
                .ForMember(x => x.Doses, opts => opts.MapFrom(x => x.Doses))
                .ForMember(x => x.Intervalo, opts => opts.MapFrom(x => x.Intervalo))
                .ForMember(x => x.Peridiocidade, opts => opts.MapFrom(x => x.Peridiocidade))
                .ForMember(x => x.AgendaId, opts => opts.Ignore());

            CreateMap<Agenda, AgendaDto>()
                .ForMember(x => x.Id, opts => opts.MapFrom(x => x.Id))
                .ForMember(x => x.VacinaId, opts => opts.MapFrom(x => x.Vacina.Id))
                .ForMember(x => x.Situacao, opts => opts.MapFrom(x => x.Situacao))
                .ForMember(x => x.DataSituacao, opts => opts.MapFrom(x => x.DataSituacao))
                .ForMember(x => x.Data, opts => opts.MapFrom(x => x.Data))
                .ForMember(x => x.Hora, opts => opts.MapFrom(x => x.Hora))
                .ForMember(x => x.Observacoes, opts => opts.MapFrom(x => x.Observacoes));

            CreateMap<Usuario, UsuarioDto>()
                .ForMember(x => x.Id, opts => opts.MapFrom(x => x.Id))
                .ForMember(x => x.Nome, opts => opts.MapFrom(x => x.Nome))
                .ForMember(x => x.Uf, opts => opts.MapFrom(x => x.Uf))
                .ForMember(x => x.Cidade, opts => opts.MapFrom(x => x.Cidade))
                .ForMember(x => x.Setor, opts => opts.MapFrom(x => x.Setor))
                .ForMember(x => x.DataNascimento, opts => opts.MapFrom(x => x.DataNascimento))
                .ForMember(x => x.Logradouro, opts => opts.MapFrom(x => x.Logradouro))
                .ForMember(x => x.Numero, opts => opts.MapFrom(x => x.Numero))
                .ForMember(x => x.Sexo, opts => opts.MapFrom(x => x.Sexo));
        }
    }
}
