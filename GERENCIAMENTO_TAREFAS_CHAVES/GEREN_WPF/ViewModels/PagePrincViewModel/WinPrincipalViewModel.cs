using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using GERENC_APPLICATION.Interfaces.Usuario;
using GERENC_WPF.ServicesWPF.Intefaces;

using GERENC_WPF.View.UsuarioView;
using Microsoft.Extensions.DependencyInjection;


using GERENC_WPF.ViewModels.PagePrincViewModel.Componente;


namespace GERENC_WPF.ViewModels
{
    public partial class WinPrincipalViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableObject currentViewModel;

        [ObservableProperty]
        private string tipo;

        private readonly IServiceProvider _provider;
        private readonly IWindowService _windowService;
        private readonly IUsuarioSessao _usuarioSessao;
       

        //private readonly InstrutorCadViewModel _instrutorCadastrosViewModel;
        //private readonly InstrutorCadastroView cadastroView

        public WinPrincipalViewModel(IServiceProvider provider, IWindowService windowService, IUsuarioSessao usuarioSessao)
        {
            _provider = provider;
            _windowService = windowService;
            _usuarioSessao = usuarioSessao;
           
            g();
            
            //CurrentViewModel = new GerencTarefaModelView();
        }

        public void g()
        {
            //Tipo = _usuarioSessao.Usuario.Tipo.ToString();
        }

        #region ====== TELAS PRINCIPAL======
        [RelayCommand]
        public void NavegarToGenTarefa()
        {
            CurrentViewModel = _provider.GetRequiredService<GerencTarefaViewModel>();
        }
        #endregion

        #region ====== TELAS WINDOWS======
        [RelayCommand]
        public void AbrirTelaInstrutor()
        {
           

        }

        [RelayCommand]
        public void AbrirTelaCurso()
        {
           
        }

        [RelayCommand]
        public void AbrirTelaSala()
        {
           
        }
        #endregion


        [RelayCommand]
        public void AbrirTelaUsuario()
        {
            _windowService.AbrirTela<UsuarioCadastroView>();
        }

        [RelayCommand]
        public void VoltarToLogin()
        {
            _windowService.OpenLoginAndCloseMain();
        }
    }
}
