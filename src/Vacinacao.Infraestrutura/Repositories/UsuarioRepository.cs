using Microsoft.EntityFrameworkCore;
using Vacinacao.Core.Domain;
using Vacinacao.Core.Interfaces.Repositories;
using Vacinacao.Infraestrutura.Data;
using Vacinacao.Infraestrutura.Repositories;

namespace Vacinacao.Infraestrutura.Repositorios
{
    public class UsuarioRepository : BaseRepository<Usuario>, IRepository<Usuario>
    {
        public UsuarioRepository(AgendaVacinacaoContext context) : base(context)
        {
        }

        protected override DbSet<Usuario> _dbSet => _context.Usuarios;
    }
}
