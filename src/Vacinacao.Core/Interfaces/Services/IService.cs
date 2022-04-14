using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacinacao.Core.Interfaces.Services
{
    public interface IService<TDto> where TDto : class
    {
        void Insert(TDto e);
        void Update(TDto updated, int key);
        IEnumerable<TDto> GetAll();
        void Delete(int key);
    }
}
