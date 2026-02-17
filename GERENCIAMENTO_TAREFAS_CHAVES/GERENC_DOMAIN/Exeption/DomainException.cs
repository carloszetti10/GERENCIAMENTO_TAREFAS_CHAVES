using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GERENC_DOMAIN.Exeption
{
    public class DomainException : Exception
    {
        public string MensagemUsuario { get; }

        public DomainException(string mensagemUsuario)
            : base(mensagemUsuario)
        {
            MensagemUsuario = mensagemUsuario;
        }

        public DomainException(string mensagemUsuario, Exception innerException)
            : base(innerException.Message, innerException)
        {
            MensagemUsuario = mensagemUsuario;
        }

    }
}
