using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GERENC_APPLICATION.DTOs.Usuario;
using GERENC_APPLICATION.Exceptions;
using GERENC_APPLICATION.Interfaces.Usuario;
using GERENC_APPLICATION.Services.Usuario;
using GERENC_WinForm;
using GERENC_WinForm.DialogService;
using GERENC_WPF.ServicesWPF.Intefaces;
using GERENC_WPF.View;
using System.Threading.Tasks;
using System.Windows;




namespace GERENC_WPF.ViewModels
{
    public partial class LoginViewModel : ObservableObject
    {
        private readonly IWindowService _windowService;
        private readonly IUsuarioService _usuarioService;
        private readonly IDialogService _dialogService;
        private readonly IUsuarioSessao _usuarioSessao;
        [ObservableProperty]
        private string usuario;

        [ObservableProperty]
        private string senha;


        public LoginViewModel(IWindowService windowService, IUsuarioService usuarioService, IDialogService dialogService, IUsuarioSessao usuarioSessao)
        {
            _dialogService = dialogService;
            _usuarioService = usuarioService;
            _windowService = windowService;
            _usuarioSessao = usuarioSessao;
        }

        [RelayCommand]
        private async Task Logar()
        {

            
            try
            {
                validarCampos();
                UsuarioRetornoDto usuarioLogado = await _usuarioService.Logar(new UsuarioLogarDto { Usuario = Usuario, Senha = Senha });

                if (usuarioLogado != null)
                {
                    _usuarioSessao.Logar(usuarioLogado);
                    _windowService.OpenMainAndCloseLogin();

                }
                else
                {
                    throw new AppException("Erro ao Logar!");
                }
            }
            catch (AppException ex)
            {
                _dialogService.ShowAtenc(ex.Message);
            }
            catch (Exception e)
            {
                _dialogService.ShowError(e.Message + "\n" + e.InnerException);
            }

        }



        private void validarCampos()
        {
            if (string.IsNullOrWhiteSpace(Usuario))
            {
                throw new AppException("Informe o usuario.");
            }

            if (string.IsNullOrWhiteSpace(Senha))
            {
                throw new AppException("Informe a senha.");
            }
        }
    }
}
