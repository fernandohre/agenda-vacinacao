using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacinacao.Core.Domain.Dto
{
    public class AgendaDto
    {
        public DateTime data { get; set; }
        public TimeSpan Hora { get; set; }
        public string Situacao { get; set; }
        public DateTime DataSituacao { get; set; }
        public string Observacoes { get; set; }
        public int VacinaId { get; set; }
    }
}
