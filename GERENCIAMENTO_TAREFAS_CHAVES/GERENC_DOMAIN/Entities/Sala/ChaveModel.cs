using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GERENC_DOMAIN.Entities.Sala
{
    public class ChaveModel
    {
       
        public int Id { get; private set; }
        public int SalaId { get; private set; }
        public string Nome { get; private set; }
        public SalaModel sala { get; private set; }

        //public ICollection<RetiradaChaveModel> Retiradas { get; private set; } = new List<RetiradaChaveModel>();

        public ChaveModel(string nome)
        {
            Nome = nome;
        }

        protected ChaveModel() { }

        public ChaveModel(string nome, SalaModel sala)
        {
            Nome = nome;
            this.sala = sala;
        }
    }
}
