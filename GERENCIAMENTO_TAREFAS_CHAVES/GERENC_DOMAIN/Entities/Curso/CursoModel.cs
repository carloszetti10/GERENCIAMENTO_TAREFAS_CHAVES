using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GERENC_DOMAIN.Entities.Curso
{
    public class CursoModel
    {

        // 🔹 Coleção real usada pelo EF
        private readonly List<CursoCategoria> _cursoCategorias = new();
        public IReadOnlyCollection<CursoCategoria> CursoCategorias => _cursoCategorias;


        public CursoModel(string nome)
        {
            Nome = nome;
        }

        protected CursoModel() { }


        public int Id { get; private set; }
        public string Nome { get; private set; }


        public void AdicionarCategoria(CategoriaModel categoria)
        {
            if (_cursoCategorias.Any(cc => cc.CategoriaId == categoria.Id))
                throw new Exception("Curso já possui essa categoria");

            _cursoCategorias.Add(new CursoCategoria(this, categoria));
        }
    }
}
