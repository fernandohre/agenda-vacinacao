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
    public class UsuarioService : IService<UsuarioDto>
    {
        private IRepository<Usuario> _repository;
        public UsuarioService(IRepository<Usuario> repository) 
        {
            _repository = repository;
        }
        public void Delete(int key)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UsuarioDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(UsuarioDto e)
        {
            throw new NotImplementedException();
        }

        public void Update(UsuarioDto updated, int key)
        {
            throw new NotImplementedException();
        }
    }
}
