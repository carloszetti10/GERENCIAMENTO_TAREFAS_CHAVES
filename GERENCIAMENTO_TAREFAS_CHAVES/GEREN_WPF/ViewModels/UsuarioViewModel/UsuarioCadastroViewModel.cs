using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GERENC_APPLICATION.Criptografia;
using GERENC_APPLICATION.DTOs.Usuario;
using GERENC_APPLICATION.Exceptions;
using GERENC_APPLICATION.Interfaces.Categoria;
using GERENC_APPLICATION.Interfaces.Usuario;
using GERENC_APPLICATION.Services.Categoria;
using GERENC_APPLICATION.Services.Usuario;
using GERENC_DOMAIN.Enum;
using GERENC_INFRAESTRUTURA.Exception;
using GERENC_INFRAESTRUTURA.Migrations;
using GERENC_WinForm.DialogService;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GERENC_WPF.ViewModels.UsuarioCadastroModel
{
    public partial class UsuarioCadastroViewModel : ObservableObject
    {

        private readonly ICategoriaService _categoriaService;
        private readonly IDialogService _dialogService;
        private readonly IUsuarioService _usuarioService;
        private readonly IAuthService _authService;
        private readonly IUsuarioSessao _usuarioSessao;

        [ObservableProperty]
        private string nome;

        [ObservableProperty]
        private string cpf;

        [ObservableProperty]
        private string usuario;

        [ObservableProperty]
        private string senha;


        //lista de usuarios 
        public ObservableCollection<UsuarioListDto> Usuarios { get; } = new();
        [ObservableProperty]
        private UsuarioListDto usuarioSelecionado;

        // Lista de categorias Agente
       

        // COMBO
        public List<TipoUsuarioEnum> TiposUsuario { get; }

        [ObservableProperty]
        private TipoUsuarioEnum tipoSelecionado;


        public UsuarioCadastroViewModel(ICategoriaService categoriaService, IDialogService dialogService, IUsuarioService usuarioService, IAuthService authService, IUsuarioSessao usuarioSessao)
        {
            _authService = authService;
            _usuarioService = usuarioService;
            _categoriaService = categoriaService;
            _dialogService = dialogService;
            _usuarioSessao = usuarioSessao;
      
            //preecher combbox
            TiposUsuario = Enum.GetValues(typeof(TipoUsuarioEnum)).Cast<TipoUsuarioEnum>().ToList();

            TipoSelecionado = TipoUsuarioEnum.Agente;
           
        }

        //BOOL SIMPLES
        public bool MostrarCategorias => TipoSelecionado == TipoUsuarioEnum.Agente;
        partial void OnTipoSelecionadoChanged(TipoUsuarioEnum value)
        {
            OnPropertyChanged(nameof(MostrarCategorias));
            CarregarCategoriasAsync();
        }


        //metodo para preencher a lista de categorias
        [RelayCommand]
        public async Task CarregarCategoriasAsync()
        {
           
        }


        //metodo para preencher a lista de Usuarios
        [RelayCommand]
        public async Task CarregarUsuariosAsync()
        {
            var lista = await _usuarioService.ListUsuariosAsync();

            Usuarios.Clear();

            foreach (var item in lista)
            {
                Usuarios.Add(item);
            }
        }





        //metodo para salvar
        [RelayCommand]
        public async Task Salvar()
        {
            try
            {
                validarCampoVazio(); //verificar se os campos estão vazios
                var dto = new UsuarioCreateDto();
                dto.Nome = Nome;
                dto.Cpf = Cpf;
                dto.Usuario = Usuario;
                dto.Senha = await _authService.GerarHashAsync(Senha);
                dto.Tipo = TipoSelecionado;
               
                _usuarioService.CriarUsuario(dto);
                _dialogService.ShowSuccess("Usuario criado com sucesso!");
               
                LimparFormulario();
            }
            catch (AppException ex)
            {
                _dialogService.ShowAtenc(ex.Message);
            }
            catch (InfraestruturaException e)
            {
                _dialogService.ShowError(e.Message + "\n" + e.InnerException);
            }
        }

        private void LimparFormulario()
        {
            Nome = string.Empty;
            Cpf = string.Empty;
            Usuario = string.Empty;
            Senha = string.Empty;
            TipoSelecionado = TipoUsuarioEnum.Adm;

            
        }


        private void validarCampoVazio()
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new AppException("Informe o nome.");
            }

            if (string.IsNullOrWhiteSpace(cpf))
            {
                //validar cpf 
                throw new AppException("Informe o cpf.");
            }

            if (string.IsNullOrWhiteSpace(usuario))
            {  
                throw new AppException("Informe o usuario.");
            }

            if (string.IsNullOrWhiteSpace(senha))
            {
                throw new AppException("Informe a senha.");
            }

            if (tipoSelecionado == TipoUsuarioEnum.Agente)
            {
               
            }
        }
    }
}
