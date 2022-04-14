using Vacinacao.Core.Domain;
using Vacinacao.Core.Interfaces.Repositories;
using Vacinacao.Infraestrutura.Repositorios;

namespace Vacinacao.Api.Extensions.IoC
{
    public static class RepositoriesIoC
    {
        public static void AddRepositories(this IServiceCollection repositories) 
        {
            repositories.AddScoped<IRepository<Agenda>, AgendaRepository>();
            repositories.AddScoped<IRepository<Alergia>, AlergiaRepository>();
            repositories.AddScoped<IRepository<Vacina>, VacinaRepository>();
            repositories.AddScoped<IRepository<Usuario>, UsuarioRepository>();
        }
    }
}
