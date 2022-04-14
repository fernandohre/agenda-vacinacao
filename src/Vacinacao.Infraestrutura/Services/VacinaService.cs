using Vacinacao.Core.Domain;
using Vacinacao.Core.Domain.Dto;
using Vacinacao.Core.Interfaces.Repositories;
using Vacinacao.Core.Interfaces.Services;

namespace Vacinacao.Infraestrutura.Services
{
    public class VacinaService : IService<VacinaDto>
    {
        private readonly IRepository<Vacina> _repository;
        public VacinaService(IRepository<Vacina> repository) 
        {
            _repository = repository;
        }
        public void Delete(int key)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VacinaDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(VacinaDto e)
        {
            throw new NotImplementedException();
        }

        public void Update(VacinaDto updated, int key)
        {
            throw new NotImplementedException();
        }
    }
}
