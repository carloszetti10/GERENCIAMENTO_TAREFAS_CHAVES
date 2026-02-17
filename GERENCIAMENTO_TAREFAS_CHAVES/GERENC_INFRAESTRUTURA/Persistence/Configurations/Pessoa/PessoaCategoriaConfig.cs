using GERENC_DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GERENC_INFRAESTRUTURA.Persistence.Configurations.Pessoa
{
    public class PessoaCategoriaConfig : IEntityTypeConfiguration<PessoaCategoria>
    {
        public void Configure(EntityTypeBuilder<PessoaCategoria> builder)
        {
            builder.HasKey(ic => new { ic.PessoaId, ic.CategoriaId });

            builder.HasOne(ic => ic.Pessoa)
                   .WithMany(i => i.PessoaCategorias)
                   .HasForeignKey(ic => ic.PessoaId);

            builder.HasOne(ic => ic.Categoria)
                   .WithMany(c => c.PessoaCategorias)
                   .HasForeignKey(ic => ic.CategoriaId);
        }
    }
}
