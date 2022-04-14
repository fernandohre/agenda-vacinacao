using Vacinacao.Core.Domain;
using Vacinacao.Core.Domain.Dto;
using Vacinacao.Core.Interfaces.Repositories;
using Vacinacao.Core.Interfaces.Services;

namespace Vacinacao.Infraestrutura.Services
{
    public class AgendaService : IService<AgendaDto>
    {
        private IRepository<Agenda> _repository;
        public AgendaService(IRepository<Agenda> repository) 
        {
            _repository = repository;
        }
        public void Delete(int key)
        {
            _repository.Delete(key);
        }

        public IEnumerable<AgendaDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(AgendaDto e)
        {
            throw new NotImplementedException();
        }

        public void Update(AgendaDto updated, int key)
        {
            throw new NotImplementedException();
        }
    }
}
