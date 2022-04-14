using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacinacao.Core.Domain.Dto
{
    public class UsuarioDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public char Sexo { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Setor { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
    }
}
