using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vacinacao.Core.Domain;

namespace Vacinacao.Infraestrutura.ConfiguracoesDeEntidade
{
    public class AlergiaEntityTypeConfiguration : IEntityTypeConfiguration<Alergia>
    {
        public void Configure(EntityTypeBuilder<Alergia> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(40);
            builder.HasMany(x => x.Usuarios);
        }
    }
}
