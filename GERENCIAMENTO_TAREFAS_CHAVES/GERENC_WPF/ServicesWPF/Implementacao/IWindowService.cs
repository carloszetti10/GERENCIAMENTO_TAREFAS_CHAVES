using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GERENC_WPF.ServicesWPF.Implementacao
{
    public interface IWindowService
    {
        void Open<TWindow>() where TWindow : Window, new();

        void OpenMain();
    }

}
