using GERENC_DOMAIN.Entities.Usuario;
using GERENC_DOMAIN.Enum;
using GERENC_DOMAIN.Exeption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GERENC_DOMAIN.Entities.Pessoas
{
    public class PorteiroModel
    {

        public int Id { get; private set; }

        public int PessoaId { get; private set; }
        public virtual PessoaBaseModel Pessoa { get; private set; }

        public int UsuarioId { get; private set; }
        public virtual UsuarioBaseModel Usuario { get; private set; }


        public PorteiroModel(PessoaBaseModel pessoa, UsuarioBaseModel usuario)
        {
            Pessoa = pessoa;
            Usuario = usuario;
        }

        protected PorteiroModel() { }
    }
}
