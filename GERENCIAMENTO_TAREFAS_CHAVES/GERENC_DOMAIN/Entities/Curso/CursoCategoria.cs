using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GERENC_DOMAIN.Entities.Curso
{
    public class CursoCategoria
    {
        public int CategoriaId {  get; private set; }
        public int CursoId { get; private set; }

        public virtual CursoModel Curso { get; private set; }
        public virtual CategoriaModel Categoria { get; private set; }

        protected CursoCategoria()
        {
        }

        public CursoCategoria(CursoModel curso, CategoriaModel categoria)
        {
            Curso = curso;
            Categoria = categoria;
        }
    }
}
