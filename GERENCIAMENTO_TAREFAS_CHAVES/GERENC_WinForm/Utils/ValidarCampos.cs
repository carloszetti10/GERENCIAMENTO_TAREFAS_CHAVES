using GERENC_APPLICATION.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GERENC_WinForm.Utils
{
    public static class ValidarCampos
    {
        public static void ValidarCamposNome(TextBox txt, string nome)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.Focus();
                throw new AppException($"Preencha o campo {nome}.");
            }
        }  
    }
}
