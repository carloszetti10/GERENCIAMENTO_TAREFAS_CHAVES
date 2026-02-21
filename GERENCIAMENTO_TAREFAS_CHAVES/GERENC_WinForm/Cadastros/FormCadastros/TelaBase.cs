using GERENC_APPLICATION.Interfaces.Categoria;
using GERENC_WinForm.DialogService;
using GERENC_WinForm.Utils;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Forms;

namespace GERENC_WinForm
{
    public partial class TelaBase : Form
    {
        protected readonly IDialogService _dialogo;
        private bool bloquearNavegacao = false;
        public EstadoCadastro? _estadoCadastro = null;

        public TelaBase()
        {
            InitializeComponent();
            if (!DesignMode && Program.ServiceProvider != null)
                _dialogo = Program.ServiceProvider.GetService<IDialogService>();
        }
        public TelaBase(IDialogService dialogo)
        {
            InitializeComponent();
            _dialogo = dialogo;
        }
        private void TelaBase_Load(object sender, EventArgs e)
        {
            DataGridViewStyle.Apply(dataList);
            iniciarButooEnable();
            DataGridViewStyle.ApplyT(tabControl);
            DataGridViewStyle.Apply(dataList);
            tabCadastro = tabControl.TabPages[0];
            tabConsulta = tabControl.TabPages[1];
        }
        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (bloquearNavegacao)
            {
                if (e.TabPage == tabConsulta)
                    e.Cancel = true;
            }
        }
        public void setarDesingButton()
        {
            ButtonStyle.Apply(btnGravar, "gravar");
            ButtonStyle.Apply(btnAlterar, "editar");
            ButtonStyle.Apply(btnApagar, "excluir");
            ButtonStyle.Apply(btnNovo, "novo");
            ButtonStyle.Apply(btnCancelar, "cancelar");
            ButtonStyle.Apply(btnPesquisar, "novo");
            ButtonStyle.Apply(btnFechar, "excluir");
        }

        #region ===== METODOS virtual =========
        protected virtual void Gravar()
        {

        }
        protected virtual void Alterar()
        {
            PegarLinhaSelecionada();
        }
        protected virtual void Apagar()
        {

        }
        protected virtual void Inserir()
        {

        }
        protected virtual void PegarObjetoClicandoTabela(object objeto)
        {

        }
        #endregion
        #region =====CONTROLES DOS BOTOES=====
        public void ControleButton(Button btnNovo, Button btnAlterar, Button btnCancelar, Button btnGravar, Button btnApagar, TabControl tabPrincipal, Boolean emEdicao)
        {
            // quando emEdicao = true → está editando
            btnNovo.Enabled = !emEdicao;
            btnAlterar.Enabled = !emEdicao;
            btnApagar.Enabled = !emEdicao;

            btnCancelar.Enabled = emEdicao;
            btnGravar.Enabled = emEdicao;

            setarDesingButton();

            // controla bloqueio
            bloquearNavegacao = emEdicao;

            // só vai para cadastro quando entrar em edição
            if (emEdicao)
                tabPrincipal.SelectedTab = tabCadastro;
        }
        public void ControllerBtnNovo()
        {
            ControleButton(btnNovo, btnAlterar, btnCancelar, btnGravar, btnApagar, tabControl, false);
            _estadoCadastro = EstadoCadastro.Inserir;
        }
        public void ControllerBtnAlterar()
        {
            ControleButton(btnNovo, btnAlterar, btnCancelar, btnGravar, btnApagar, tabControl, true);
            _estadoCadastro = EstadoCadastro.Alterar;
        }

        public void ControllerBtnCancelar()
        {
            ControleButton(btnNovo, btnAlterar, btnCancelar, btnGravar, btnApagar, tabControl, false);
            _estadoCadastro = EstadoCadastro.Nenhum;
        }


        void iniciarButooEnable()
        {
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnApagar.Enabled = false;

            btnCancelar.Enabled = false;
            btnGravar.Enabled = false;
            setarDesingButton();
        }


        #endregion
        #region =====CONTROLES CLICK=====
        private void btnNovo_Click(object sender, EventArgs e)
        {

            ControleButton(btnNovo, btnAlterar, btnCancelar, btnGravar, btnApagar, tabControl, true);
            _estadoCadastro = EstadoCadastro.Inserir;
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Alterar();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ControllerBtnCancelar();
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {

            Gravar();
        }
        private void btnApagar_Click(object sender, EventArgs e)
        {
            Apagar();
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        

        private void dataList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se clicou em uma linha válida
            if (e.RowIndex >= 0)
            {
                // Pega o objeto da linha
                object objetoSelecionado =
                dataList.Rows[e.RowIndex].DataBoundItem;

                PegarObjetoClicandoTabela(objetoSelecionado);
            }
        }

        private void PegarLinhaSelecionada()
        {
            if (dataList.SelectedRows.Count > 0)
            {
                var linha = dataList.SelectedRows[0];

                var objetoSelecionado = linha.DataBoundItem;

                PegarObjetoClicandoTabela(objetoSelecionado);
            }
            else
            {
                MessageBox.Show("Selecione um intem.");
            }
        }
    }
}
