using Microsoft.EntityFrameworkCore;
using Vacinacao.Core.Domain;
using Vacinacao.Core.Interfaces.Repositories;
using Vacinacao.Infraestrutura.Data;
using Vacinacao.Infraestrutura.Repositories;

namespace Vacinacao.Infraestrutura.Repositorios
{
    public class VacinaRepository : BaseRepository<Vacina>, IRepository<Vacina>
    {
        public VacinaRepository(AgendaVacinacaoContext context) : base(context)
        {
        }

        protected override DbSet<Vacina> _dbSet => _context.Vacinas;
    }
}
