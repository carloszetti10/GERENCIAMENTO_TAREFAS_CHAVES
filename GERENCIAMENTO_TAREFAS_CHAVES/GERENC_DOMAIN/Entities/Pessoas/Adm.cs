using GERENC_DOMAIN.Entities.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GERENC_DOMAIN.Entities.Pessoas
{
    public class Adm
    {

        public int Id { get; private set; }

        public int PessoaId { get; private set; }
        public virtual PessoaBaseModel Pessoa { get; private set; }

        public int UsuarioId { get; private set; }
        public virtual UsuarioBaseModel Usuario { get; private set; }

        protected Adm() { }

        public Adm(PessoaBaseModel pessoa, UsuarioBaseModel usuario)
        {
            Pessoa = pessoa;
            Usuario = usuario;
        }
    }
}
