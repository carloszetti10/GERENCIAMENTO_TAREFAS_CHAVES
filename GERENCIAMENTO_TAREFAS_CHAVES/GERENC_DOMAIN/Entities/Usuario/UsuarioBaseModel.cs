using GERENC_DOMAIN.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GERENC_DOMAIN.Entities.Usuario
{
    public class UsuarioBaseModel
    {


        public int Id { get; private set; }
        public string Usuario {  get; private set; }
        public string Senha { get; private set; }

        public TipoUsuarioEnum Tipo { get; private set; }

        

        protected UsuarioBaseModel() {}

        public UsuarioBaseModel(string usuario, string senha, string cpf, TipoUsuarioEnum tipo)
        {
            Usuario = usuario;
            Senha = senha; 
            Tipo = tipo;
        }
    }
}
