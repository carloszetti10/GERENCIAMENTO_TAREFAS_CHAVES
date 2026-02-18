using GERENC_APPLICATION.DTOs.Categoria;
using GERENC_APPLICATION.Exceptions;
using GERENC_APPLICATION.Interfaces.Categoria;
using GERENC_INFRAESTRUTURA.Exception;
using GERENC_WinForm.Desing;
using GERENC_WinForm.DialogService;
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

        public FormInstrutor(IDialogService dialogo, ICategoriaService categoriaService)
        {
            InitializeComponent();
            _dialogo = dialogo;
            _categoriaService = categoriaService;
            CheckedListBoxStyle.Apply(checkedListCategoria);
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
            foreach (CategoriaListDto categoria in checkedListCategoria.CheckedItems)
            {
                categoriasSelecionadas.Add(categoria);
            }
        }

        protected override void Gravar()
        {
            pegarCategoriaSelecionada();
            foreach (CategoriaListDto categoria in categoriasSelecionadas)
            {

                MessageBox.Show($"Id: {categoria.Id} - Nome: {categoria.Nome}");
            }
        }

        private void checkedListCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
