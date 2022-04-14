using AutoMapper;
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
        private IMapper _mapper;
        public AlergiaService(IRepository<Alergia> repository, IMapper mapper) 
        {
            _repository = repository;
            _mapper = mapper;
        }
        public void Delete(int key)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AlergiaDto> GetAll()
        {
            var items = _repository.GetAll();

            var result = _mapper.Map<IEnumerable<AlergiaDto>>(items);

            return result;
        }

        public void Insert(AlergiaDto e)
        {
            var entity = _mapper.Map<Alergia>(e);
            _repository.Insert(entity);
        }

        public void Update(AlergiaDto updated, int key)
        {
            throw new NotImplementedException();
        }
    }
}
