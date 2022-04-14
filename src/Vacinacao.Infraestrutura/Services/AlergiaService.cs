using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vacinacao.Core.Domain;
using Vacinacao.Core.Domain.Dto;
using Vacinacao.Core.Interfaces.Repositories;
using Vacinacao.Core.Interfaces.Services;

namespace Vacinacao.Infraestrutura.Services
{
    public class AlergiaService : IService<AlergiaDto>
    {
        private IRepository<Alergia> _repository;
        public AlergiaService(IRepository<Alergia> repository) 
        {
            _repository = repository;
        }
        public void Delete(int key)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AlergiaDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(AlergiaDto e)
        {
            throw new NotImplementedException();
        }

        public void Update(AlergiaDto updated, int key)
        {
            throw new NotImplementedException();
        }
    }
}
