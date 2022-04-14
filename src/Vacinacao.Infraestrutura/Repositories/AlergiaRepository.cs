using Microsoft.EntityFrameworkCore;
using Vacinacao.Core.Domain;
using Vacinacao.Core.Interfaces.Repositories;
using Vacinacao.Infraestrutura.Data;
using Vacinacao.Infraestrutura.Repositories;

namespace Vacinacao.Infraestrutura.Repositorios
{
    public class AlergiaRepository : BaseRepository<Alergia>, IRepository<Alergia>
    {
        public AlergiaRepository(AgendaVacinacaoContext context) : base(context)
        {
        }

        protected override DbSet<Alergia> _dbSet => _context.Alergias;
    }
}
