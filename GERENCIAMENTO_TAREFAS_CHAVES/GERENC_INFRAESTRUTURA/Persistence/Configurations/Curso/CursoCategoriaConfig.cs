using GERENC_DOMAIN.Entities.Curso;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GERENC_INFRAESTRUTURA.Persistence.Configurations.Curso
{
    internal class CursoCategoriaConfig : IEntityTypeConfiguration<CursoCategoria>
    {
        public void Configure(EntityTypeBuilder<CursoCategoria> builder)
        {
            builder.HasKey(ic => new { ic.CursoId, ic.CategoriaId });

            builder.HasOne(ic => ic.Curso)
                  .WithMany(i => i.CursoCategorias)
                  .HasForeignKey(ic => ic.CursoId);

            builder.HasOne(ic => ic.Categoria)
                   .WithMany(c => c.CursoCategorias)
                   .HasForeignKey(ic => ic.CategoriaId);
        }
    }
}
