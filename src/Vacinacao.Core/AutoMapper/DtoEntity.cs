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
        }

        private void CreateMapEntityToDto() 
        {
            CreateMap<Alergia, AlergiaDto>()
                .ForMember(x => x.Id, opts => opts.MapFrom(x => x.Id))
                .ForMember(x => x.Nome, opts => opts.MapFrom(x => x.Nome));
        }
    }
}
