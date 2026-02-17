
using GERENC_WPF.ServicesWPF.Intefaces;
using GERENC_WPF.View;

using GERENC_WPF.View.TarefaView;
using GERENC_WPF.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GERENC_WPF.ServicesWPF.Implementacao
{
    public class WindowService : IWindowService
    {
        private readonly IServiceProvider _provider;

        public WindowService(IServiceProvider provider)
        {
            _provider = provider;
        }

        public void AbrirTela<TWindow>() where TWindow : Window
        {
            //var win = _provider.GetRequiredService<TWindow>();
            //win.Owner = Application.Current.MainWindow; // define a Main como dona
            //win.ShowDialog(); //  MODAL
        }

        // LOGIN → SISTEMA
        public void OpenMainAndCloseLogin()
        {
            var main = _provider.GetRequiredService<WinPrincipalView>();

            var login = System.Windows.Application.Current.MainWindow;

            System.Windows.Application.Current.MainWindow = main;
            main.Show();

            login?.Close();
        }

        // LOGOUT → LOGIN
        public void OpenLoginAndCloseMain()
        {

            //var login = _provider.GetRequiredService<WinLogin>();

            //var main = Application.Current.MainWindow;

            //Application.Current.MainWindow = login;
            //login.Show();

            //main?.Close();
        }


        public void AbrirInstrutor()
        {
            //var win = _provider.GetRequiredService<InstrutorView>();
            //win.Owner = Application.Current.MainWindow; // define a Main como dona
            //win.ShowDialog(); //  MODAL
        }

        public void AbrirCategoria()
        {
            //var win = _provider.GetRequiredService<CategoriaView>();
            //win.Owner = Application.Current.MainWindow; // define a Main como dona
            //win.ShowDialog(); //  MODAL
        }

        public void AbrirLogin()
        {
            var win = _provider.GetRequiredService<WinLogin>();
           
            win.ShowDialog(); //  MODAL
        }

        public void AbrirTarefaCad()
        {
            //var win = _provider.GetRequiredService<TarefaCadView>();
            //win.Owner = Application.Current.MainWindow; // define a Main como dona
            //win.ShowDialog(); //  MODAL
        }



        public void AbrirTelaTipo<TView>(Action<object> configurarViewModel)
            where TView : Window
            {
                //var view = _provider.GetRequiredService<TView>();

                //if (view.DataContext != null)
                //configurarViewModel(view.DataContext);
                //view.Owner = Application.Current.MainWindow; // define a Main como dona
                //view.ShowDialog(); //  MODAL
        }
    }

}
