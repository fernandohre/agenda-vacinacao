using Vacinacao.Core.Domain.Dto;
using Vacinacao.Core.Interfaces.Services;
using Vacinacao.Infraestrutura.Services;

namespace Vacinacao.Api.Extensions.IoC
{
    public static class ServicesIoC
    {
        public static void AddServices(this IServiceCollection services) 
        {
            services.AddScoped<IService<AgendaDto>, AgendaService>();
            services.AddScoped<IService<VacinaDto>, VacinaService>();
            services.AddScoped<IService<UsuarioDto>, UsuarioService>();
            services.AddScoped<IService<AlergiaDto>, AlergiaService>();
        }
    }
}
