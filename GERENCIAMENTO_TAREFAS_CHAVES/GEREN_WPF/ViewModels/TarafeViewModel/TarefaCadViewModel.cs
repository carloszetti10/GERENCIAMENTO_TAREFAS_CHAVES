using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GERENC_APPLICATION.DTOs.Curso;
using GERENC_APPLICATION.DTOs.Instrutor;
using GERENC_WinForm.DialogService;
using GERENC_WPF.ServicesWPF.Intefaces;

using GERENC_WPF.ViewModels.PagePrincViewModel.Componente;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;


namespace GERENC_WPF.ViewModels.TarafeViewModel
{

    public partial class TarefaCadViewModel : ObservableObject
    {
        private readonly IDialogService _dialogService;
        private readonly IWindowService _windowService;

        public TarefaCadViewModel(IDialogService dialogService, IWindowService windowService)
        {
            _dialogService = dialogService;
            _windowService = windowService;
        }

        #region ==============SELECIONAR INSTRUTOR=============
        public int? IdInstrutoreSelecionado { get; private set; }
        [ObservableProperty]
        private string? instrutorNome;

        [RelayCommand]
        public void BuscarInstrutor()
        {
            
        }
        public void limparInstrutor()
        {
            IdInstrutoreSelecionado = null;
            instrutorNome = string.Empty;
        }
        #endregion

        #region ==========SELECIONAR CURSO===============
        public int? IdCursolecionado { get; private set; }
        [ObservableProperty]
        private string? cursoNome;

        [RelayCommand]
        public void BuscarCurso()
        {
           
        }
        public void limparCurso()
        {
            IdCursolecionado = null;
            CursoNome = string.Empty;
        }
        #endregion

        #region ==============SELECIONAR SALA=============
        //public int? IdSalaSelecionada { get; private set; }
        //[ObservableProperty]
        //private string? salaNome;

        //[RelayCommand]
        //public void BuscarSala()
        //{
        //    _windowService.AbrirTelaTipo<PrinCadastrosView>(vm =>
        //    {
        //        var viewModel = (PrinCadastrosViewModel)vm;

        //        viewModel.InicializarConsulta(TipoCadastroTela.Instrutor, "TelaTarefa");

        //        viewModel.SelecionarItem = item =>
        //        {
        //            if (item is InstrutorListDto instrutor)
        //            {
        //                limparInstrutor();
        //                IdInstrutoreSelecionado = instrutor.Codigo;
        //                InstrutorNome = instrutor.Nome;

        //            }
        //        };
        //    });
        //}
        //public void limparSala()
        //{
        //    IdInstrutoreSelecionado = null;
        //    instrutorNome = string.Empty;
        //}
        #endregion

    }
}
