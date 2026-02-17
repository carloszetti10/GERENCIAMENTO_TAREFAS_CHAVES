using GERENC_DOMAIN.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GERENC_DOMAIN.Entities.Pessoas
{
    public class FuncionarioModel : PessoaBaseModel
    {
        public FuncionarioModel(string nome, string cpf, TipoPessoaEnum tipoPessoa) : base(nome, cpf, tipoPessoa)
        {
        }

        protected FuncionarioModel() { }
    }
}
