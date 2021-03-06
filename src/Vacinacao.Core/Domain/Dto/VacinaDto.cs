using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacinacao.Core.Domain.Dto
{
    public class VacinaDto
    {
        public int? Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int Doses { get; set; }
        public int Peridiocidade { get; set; }
        public int Intervalo { get; set; }
        public int AgendaId { get; set; }
    }
}
