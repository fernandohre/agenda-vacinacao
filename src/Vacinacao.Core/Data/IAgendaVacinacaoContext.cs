using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vacinacao.Core.Domain;

namespace Vacinacao.Core.Data
{
    public interface IAgendaVacinacaoContext
    {
        DbSet<Agenda> Agendas { get; set; }
        DbSet<Vacina> Vacinas { get; set; }
        DbSet<Usuario> Usuarios { get; set; }
        DbSet<Alergia> Alergias { get; set; }
    }
}
