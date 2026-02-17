using GERENC_DOMAIN.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GERENC_DOMAIN.Entities.Pessoas
{
    public class PessoaBaseModel
    {

        // 🔹 Coleção real usada pelo EF
        private readonly List<PessoaCategoria> _pessoaCategorias = new();
        public IReadOnlyCollection<PessoaCategoria> PessoaCategorias => _pessoaCategorias;

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Cpf { get; private set; }

        public TipoPessoaEnum TipoPessoa { get; private set; }
      
        protected PessoaBaseModel() { }

        public PessoaBaseModel(string nome, string cpf, TipoPessoaEnum tipoPessoa)
        {
            Nome = nome;
            Cpf = cpf;
            TipoPessoa = tipoPessoa;
        }

        public void AdicionarCategoria(CategoriaModel categoria)
        {
            if (_pessoaCategorias.Any(ic => ic.CategoriaId == categoria.Id))
                throw new Exception("Instrutor já possui essa categoria");

            _pessoaCategorias.Add(new PessoaCategoria(this.Id, categoria.Id));
        }

        //public void RemoverCategoria(Categoria categoria)
        //{
        //    var item = _instrutorCategorias
        //        .FirstOrDefault(ic => ic.CategoriaId == categoria.Id);

        //    if (item != null)
        //        _instrutorCategorias.Remove(item);
        //}
    }
}
