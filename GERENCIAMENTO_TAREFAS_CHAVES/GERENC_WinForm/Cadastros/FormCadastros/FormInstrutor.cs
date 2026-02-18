using GERENC_APPLICATION.DTOs.Categoria;
using GERENC_APPLICATION.Exceptions;
using GERENC_APPLICATION.Interfaces.Categoria;
using GERENC_APPLICATION.Services.Instrutor;
using GERENC_INFRAESTRUTURA.Exception;
using GERENC_WinForm.Desing;
using GERENC_WinForm.DialogService;
using GERENC_WinForm.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GERENC_WinForm.Cadastros.FormCadastros
{
    public partial class FormInstrutor : TelaBase
    {
        private IDialogService _dialogo;
        private readonly ICategoriaService _categoriaService;
        private readonly IInstrutorService _instrutorService;

        public FormInstrutor(IDialogService dialogo, ICategoriaService categoriaService, IInstrutorService instrutorService)
        {
            InitializeComponent();
            _dialogo = dialogo;
            _categoriaService = categoriaService;
            _instrutorService = instrutorService;
            CheckedListBoxStyle.Apply(checkedListCategoria);
            TextBoxStyle.Apply(txtNomeInstrutor);
            _ = preencherCkeckListAsync();
        }

        public async Task preencherCkeckListAsync()
        {
            try
            {
                checkedListCategoria.Items.Clear();
                checkedListCategoria.DisplayMember = "Nome";
                checkedListCategoria.ValueMember = "Id";
                IEnumerable<CategoriaListDto> categorias = await _categoriaService.ListarTCategoriasAsync();

                foreach (var categoria in categorias)
                {
                    checkedListCategoria.Items.Add(categoria);
                }
            }
            catch (AppException ex)
            {
                _dialogo.ShowError(ex.Message);
            }
            catch (InfraestruturaException e)
            {
                _dialogo.ShowError(e.Message);
            }

        }

        private List<CategoriaListDto> categoriasSelecionadas = new List<CategoriaListDto>();
        public void pegarCategoriaSelecionada()
        {
            categoriasSelecionadas.Clear();
            //pegar categoria selcionada
            foreach (CategoriaListDto categoria in checkedListCategoria.CheckedItems)
            {
                categoriasSelecionadas.Add(categoria);
            }

            //retornar exeption se a não tiver categoria selecionada
            if(categoriasSelecionadas.Count == 0)
            {
                throw new AppException("Selecione pelo menos uma categoria.");
            }
        }

        #region =====METODOS HERDADO DA TELABASE======
        protected override void Alterar()
        {
            MessageBox.Show("Clicou em alterar");
        }
        protected override void Apagar()
        {
            MessageBox.Show("Apagando");
        }
        protected override void Gravar()
        {
            try
            {
                ValidarCampos.ValidarCamposNome(txtNomeInstrutor, "Nome");
                pegarCategoriaSelecionada();
                //ControleButton(btnNovo, btnAlterar, btnCancelar, btnGravar, btnApagar, tabControl, false);
            }
            catch (AppException ex)
            {
                _dialogo.ShowAtenc(ex.Message);
            }
            catch (InfraestruturaException e)
            {
                _dialogo.ShowAtenc(e.Message);
            }
        }
        #endregion
    }
}
