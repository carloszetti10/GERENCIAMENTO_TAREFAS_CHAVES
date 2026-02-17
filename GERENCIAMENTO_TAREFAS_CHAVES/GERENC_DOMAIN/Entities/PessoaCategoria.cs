using GERENC_DOMAIN.Entities.Pessoas;

namespace GERENC_DOMAIN.Entities
{
    public class PessoaCategoria
    {

        public int PessoaId { get; private set; }
        public virtual PessoaBaseModel Pessoa { get; private set; }

        public int CategoriaId { get; private set; }
        public virtual CategoriaModel Categoria { get; private set; }

        protected PessoaCategoria(PessoaBaseModel pessoaBaseModel) { }

        public PessoaCategoria(int pessoaId, int categoriaId)
        {
            PessoaId = pessoaId;
            CategoriaId = categoriaId;
        }

        public PessoaCategoria( PessoaBaseModel pessoa, CategoriaModel categoria)
        {
            Pessoa = pessoa;
            Categoria = categoria;
        }
    }
}