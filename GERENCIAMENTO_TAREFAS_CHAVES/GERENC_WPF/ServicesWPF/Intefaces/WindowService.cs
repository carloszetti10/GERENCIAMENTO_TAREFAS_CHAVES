using GERENC_WPF.ServicesWPF.Implementacao;
using GERENC_WPF.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GERENC_WPF.ServicesWPF.Intefaces
{
    public class WindowService : IWindowService
    {
        public void Open<TWindow>() where TWindow : Window, new()
        {
            var win = new TWindow();
            win.ShowDialog();
        }

        public void OpenMain()
        {
            var win = new WinPrincipalView();
            Application.Current.MainWindow = win;
            win.Show();
        }

        //public void Close() 
        //{
        //    DataContextChanged += (sender, e) =>
        //    {
        //        if (Application.Current.MainWindow != this)
        //            Close();
        //    };
        //}

    }

}
