using GERENC_DOMAIN.Entities.Curso;

namespace GERENC_DOMAIN.Entities
{
    public class CategoriaModel
    {

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public ICollection<PessoaCategoria> PessoaCategorias { get; set; }
        public ICollection<CursoCategoria> CursoCategorias { get; set; }
        public ICollection<SalaCategoria> SalaCategorias { get; set; }

        protected CategoriaModel() { }

        public CategoriaModel(string nome)
        {
            Nome = nome;
            PessoaCategorias = new List<PessoaCategoria>();
            CursoCategorias = new List<CursoCategoria>();
            SalaCategorias = new List<SalaCategoria>();
        }
    }
}