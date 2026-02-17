using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GERENC_WPF.ServicesWPF.Intefaces
{
    public interface IWindowService
    {
        void AbrirTela<TWindow>() where TWindow : Window;

        void OpenMainAndCloseLogin();

        void OpenLoginAndCloseMain();

        void AbrirInstrutor();
        void AbrirCategoria();
        void AbrirTarefaCad();
        void AbrirTelaTipo<TView>(Action<object> value) where TView : Window;

    }

}
