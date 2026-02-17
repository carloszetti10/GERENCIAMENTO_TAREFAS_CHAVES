using GERENC_APPLICATION.Criptografia;
using GERENC_APPLICATION.Interfaces.Categoria;
using GERENC_APPLICATION.Interfaces.Curso;
using GERENC_APPLICATION.Interfaces.Sala;
using GERENC_APPLICATION.Interfaces.Usuario;
using GERENC_APPLICATION.Services.Categoria;
using GERENC_APPLICATION.Services.Curso;
using GERENC_APPLICATION.Services.Instrutor;
using GERENC_APPLICATION.Services.Sala;
using GERENC_APPLICATION.Services.Usuario;
using GERENC_INFRAESTRUTURA.Persistence;
using GERENC_WinForm.Cadastros.FormCadastros;
using GERENC_WinForm.DialogService;
using GERENC_WPF.Conexao.ConexaoModell;
using GERENC_WPF.Conexao.ConexaoView;
using GERENC_WPF.ServicesWPF.Implementacao;
using GERENC_WPF.ServicesWPF.Intefaces;
using GERENC_WPF.View;
using GERENC_WPF.View.PagePrinc;
using GERENC_WPF.View.TarefaView;
using GERENC_WPF.View.UsuarioView;
using GERENC_WPF.ViewModels;
using GERENC_WPF.ViewModels.PagePrincViewModel.Componente;
using GERENC_WPF.ViewModels.TarafeViewModel;
using GERENC_WPF.ViewModels.UsuarioCadastroModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using System.Windows;




namespace GERENC_WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : System.Windows.Application
    {
        #region ====== SERVICE PROVIDER ======
        public static ServiceProvider ServiceProvider { get; private set; }
        #endregion


        #region ====== STARTUP ======
        protected override async void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // 🔹 Verificação e configuração da conexão
            try
            {
                if (ConexaoStartupService.ExisteConexao())
                    ConexaoStartupService.ConectarPrimeira();
                else
                    new CadastroConexaoView().ShowDialog();
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }

            // 🔹 Se não houver conexão válida, encerra o app
            if (string.IsNullOrEmpty(AppConnection.Current))
            {
                Shutdown();
                return;
            }

            // 🔹 Configuração do Dependency Injection
            var services = new ServiceCollection();
            #endregion


            #region ====== DATABASE ======
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(AppConnection.Current));
            #endregion


            #region ====== SERVICES ======
            services.AddSingleton<IWindowService, WindowService>();
            services.AddSingleton<INavigationService, NavigationService>();
            services.AddSingleton<IAuthService, AuthService>();

            services.AddSingleton<IInstrutorService, InstrutorService>();
            services.AddSingleton<ICategoriaService, CategoriaService>();

            services.AddSingleton<IUsuarioService, UsuarioService>();
            services.AddSingleton<IUsuarioSessao, UsuarioSessao>();

            services.AddSingleton<ICursoService, CursoService>();
            services.AddSingleton<ISalaService, SalaService>();

            services.AddSingleton<IDialogService, DialogoService>();



            #endregion


            #region ====== VIEWMODELS ======
            services.AddTransient<LoginViewModel>();
            services.AddTransient<WinPrincipalViewModel>();
            services.AddTransient<GerencTarefaViewModel>();

           

            services.AddTransient<TarefaCadViewModel>();

           

            services.AddTransient<UsuarioCadastroViewModel>();

          

           
            #endregion


            #region ====== VIEWS ======
            services.AddTransient<WinLogin>();
            services.AddTransient<WinPrincipalView>();
            services.AddTransient<GerencTarefaView>();

        

            services.AddTransient<TarefaCadView>();


            services.AddTransient<UsuarioCadastroView>();


            services.AddTransient<InicialView>();

            // Forms WinForms
            services.AddTransient<FormCategoria>();
            services.AddTransient<FormConsultor>();


            #endregion


            #region ====== BUILD PROVIDER ======
            ServiceProvider = services.BuildServiceProvider();
            #endregion


            #region ====== EF CORE PRELOAD ======
            using (var scope = ServiceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                context.Database.CanConnect();
            }
            #endregion

            // 🔹 Abre o app (splash + login)
            await AbrirAppAsync();
        }


        #region ====== MÉTODOS AUXILIARES ======
        public void ShowError(string message, string title = "Erro")
        {
            System.Windows.MessageBox.Show(
                message,
                title,
                MessageBoxButton.OK,
                MessageBoxImage.Error);
        }

        private async Task AbrirAppAsync()
        {
            try
            {
                // Splash
                var splash = ServiceProvider.GetRequiredService<InicialView>();
                splash.Show();

                await Task.Delay(2500);

                splash.Close();

                // Login
                var login = ServiceProvider.GetRequiredService<WinLogin>();
                MainWindow = login;
                login.Show();
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
                Shutdown();
            }
        }
        #endregion

        #region ====== FLUXO ANTIGO DE LOGIN (REFERÊNCIA) ======
        //private async Task AbrirAppAsync()
        //{
        //    try
        //    {
        //        // SPLASH
        //        var splash = ServiceProvider.GetRequiredService<InicialView>();
        //        splash.Show();
        //
        //        await Task.Delay(2500);
        //        splash.Close();
        //
        //        // LOGIN (NÃO é MainWindow)
        //        var login = ServiceProvider.GetRequiredService<WinLogin>();
        //        var resultado = login.ShowDialog(); // MODAL
        //
        //        if (resultado != true)
        //        {
        //            Shutdown();
        //            return;
        //        }
        //
        //        // MAIN (SÓ AGORA!)
        //        var main = ServiceProvider.GetRequiredService<WinPrincipalView>();
        //        MainWindow = main;     // 🔥 AQUI SIM
        //        main.Show();
        //    }
        //    catch (Exception ex)
        //    {
        //        ShowError(ex.Message);
        //        Shutdown();
        //    }
        //}

        #endregion
    }
}
