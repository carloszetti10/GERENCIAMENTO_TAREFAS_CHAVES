using GERENC_DOMAIN.Entities.Curso;
using GERENC_DOMAIN.Entities.Sala;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GERENC_DOMAIN.Entities
{
    public class SalaCategoria
    {
        public int CategoriaId { get; private set; }
        public int SalaId { get; private set; }

        public virtual SalaModel Sala { get; private set; }
        public virtual CategoriaModel Categoria { get; private set; }

        protected SalaCategoria()
        {
        }

        public SalaCategoria(SalaModel sala, CategoriaModel categoria)
        {
            Sala = sala;
            Categoria = categoria;
        }
    }
}
