using Microsoft.EntityFrameworkCore;
using Vacinacao.Core.Domain;
using Vacinacao.Core.Interfaces.Repositories;
using Vacinacao.Infraestrutura.Data;
using Vacinacao.Infraestrutura.Repositories;

namespace Vacinacao.Infraestrutura.Repositorios
{
    public class AgendaRepository : BaseRepository<Agenda>, IRepository<Agenda>
    {
        public AgendaRepository(AgendaVacinacaoContext context) : base(context)
        {
        }

        protected override DbSet<Agenda> _dbSet => _context.Agendas;
    }
}
