using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacinacao.Core.Domain
{
    public class Vacina : IEntity
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int Doses { get; set; }
        public int Peridiocidade { get; set; }
        public int Intervalo { get; set; }
        public List<Agenda> Agendas { get; set; }
    }
}
