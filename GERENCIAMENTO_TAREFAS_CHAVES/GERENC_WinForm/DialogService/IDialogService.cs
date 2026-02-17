using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GERENC_WinForm.DialogService
{
    public interface IDialogService
    {
        void ShowInfo(string message, string title = "Informação");
        void ShowSuccess(string message, string title = "Sucesso");
        void ShowAtenc(string message, string title = "Atenção");
        void ShowError(string message, string title = "Erro");

        bool Confirm(string message, string title = "Confirmação");
    }
}
