using GERENC_DOMAIN.Entities.Curso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GERENC_DOMAIN.Entities.Sala
{
    public class SalaModel
    {
        public int Id { get; private set;}

        public string Nome { get; private set;}

        // 🔹 Coleção real usada pelo EF
        private readonly List<SalaCategoria> _salaCategorias = new();
        public IReadOnlyCollection<SalaCategoria> SalaCategorias => _salaCategorias;

        private readonly List<ChaveModel> _chaves = new();
        public IReadOnlyCollection<ChaveModel> Chaves => _chaves;

        protected SalaModel() { }

        public SalaModel(string nome)
        {
            Nome = nome;
        }

        public void AdicionarChave(string n)
        {
            _chaves.Add(new ChaveModel(n,this));
        }

        public void AdicionarCategoria(CategoriaModel categoria)
        {
            if (_salaCategorias.Any(cc => cc.CategoriaId == categoria.Id))
                throw new Exception("Sala já possui essa categoria");

            _salaCategorias.Add(new SalaCategoria(this, categoria));
        }
    }
}
