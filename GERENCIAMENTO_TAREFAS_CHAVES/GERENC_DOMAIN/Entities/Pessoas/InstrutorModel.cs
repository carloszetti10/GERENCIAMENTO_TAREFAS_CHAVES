using GERENC_DOMAIN.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GERENC_DOMAIN.Entities.Pessoas
{
    public class InstrutorModel : PessoaBaseModel
    {
        //public int Id { get; private set; }

        protected InstrutorModel()
        {
        }

        public InstrutorModel(string nome, string cpf)
            : base(nome, cpf, TipoPessoaEnum.Instrutor)
        {
        }
    }
}   
