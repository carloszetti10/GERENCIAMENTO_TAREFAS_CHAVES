using GERENC_APPLICATION.DTOs.Categoria;
using GERENC_APPLICATION.Exceptions;
using GERENC_APPLICATION.Interfaces.Categoria;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;


namespace GERENC_WinForm.Cadastros.FormCadastros
{
    public partial class FormCategoria : TelaBase
    {
        // construtor obrigatório para o Designer
        public FormCategoria()
        {
            InitializeComponent();
        }

        // construtor usado pelo DI
        private IDialogService _dialogo;
        private readonly ICategoriaService _categoriaService;
        public FormCategoria(IDialogService dialogo, ICategoriaService categoria) : base(dialogo)
        {
            InitializeComponent();
            
            _dialogo = dialogo;
            _categoriaService = categoria;
            //this.Load += FormCategoria_Load;
        }

        private async void FormCategoria_Load(object sender, EventArgs e)
        {
            
            if (_categoriaService != null)
                await CarregarLista();
        }

        protected override void Gravar()
        {
            try
            {
                if (_estadoCadastro == EstadoCadastro.Inserir)
                {
                    ValidarCampo();
                    _categoriaService.createCategoria(new CategoriaCreateDto { Nome = TNomeCategoria.Text });
                    _dialogo.ShowSuccess("Categoria gravada com sucesso!");
                    TNomeCategoria.Text = "";
                }
                else if (_estadoCadastro == EstadoCadastro.Alterar)
                {
                    _dialogo.ShowSuccess("Alterando");
                }     
            }
            catch (AppException ex) 
            {
               _dialogo.ShowAtenc(ex.Message);
            }catch(InfraestruturaException e)
            {
                _dialogo.ShowError(e.Message); 
            }
        }

        public void ValidarCampo()
        {
            if (string.IsNullOrWhiteSpace(TNomeCategoria.Text))
            {
                TNomeCategoria.Focus();
                throw new AppException("Informe o nome da categoria.");
            }
        }

        private async Task CarregarLista()
        {
            var lista = await _categoriaService.ListarTCategoriasAsync();
            dataList.DataSource = lista;
            dataList.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataList.Columns[0].Width = 50;
        }

        private async void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (CBoxTodos.Checked)
                await CarregarLista();
        }

        private void CBoxTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (CBoxTodos.Checked)
            {
                txtPesquisa.Enabled = false;
                txtPesquisa.Text = "";
            } else
            {
                txtPesquisa.Enabled = true;
            }    
        }
    }
}
