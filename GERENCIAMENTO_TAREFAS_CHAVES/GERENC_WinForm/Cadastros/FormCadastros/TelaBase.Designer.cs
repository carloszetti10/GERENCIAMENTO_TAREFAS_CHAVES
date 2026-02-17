
namespace GERENC_WinForm
{
    public partial class TelaBase : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlInferior = new Panel();
            btnFechar = new Button();
            btnApagar = new Button();
            btnCancelar = new Button();
            btnAlterar = new Button();
            btnGravar = new Button();
            btnNovo = new Button();
            tabControl = new TabControl();
            tabCadastro = new TabPage();
            tabConsulta = new TabPage();
            dataList = new DataGridView();
            pnlPesquisa = new Panel();
            CBoxTodos = new CheckBox();
            btnPesquisar = new Button();
            txtPesquisa = new TextBox();
            pnlInferior.SuspendLayout();
            tabControl.SuspendLayout();
            tabConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataList).BeginInit();
            pnlPesquisa.SuspendLayout();
            SuspendLayout();
            // 
            // pnlInferior
            // 
            pnlInferior.Controls.Add(btnFechar);
            pnlInferior.Controls.Add(btnApagar);
            pnlInferior.Controls.Add(btnCancelar);
            pnlInferior.Controls.Add(btnAlterar);
            pnlInferior.Controls.Add(btnGravar);
            pnlInferior.Controls.Add(btnNovo);
            pnlInferior.Dock = DockStyle.Bottom;
            pnlInferior.Location = new Point(0, 406);
            pnlInferior.Margin = new Padding(4, 3, 4, 3);
            pnlInferior.Name = "pnlInferior";
            pnlInferior.Size = new Size(548, 44);
            pnlInferior.TabIndex = 0;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(465, 9);
            btnFechar.Margin = new Padding(4, 3, 4, 3);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 23);
            btnFechar.TabIndex = 5;
            btnFechar.Text = "FECHAR";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnApagar
            // 
            btnApagar.Location = new Point(331, 9);
            btnApagar.Margin = new Padding(4, 3, 4, 3);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(75, 23);
            btnApagar.TabIndex = 4;
            btnApagar.Text = "APAGAR";
            btnApagar.UseVisualStyleBackColor = true;
            btnApagar.Click += btnApagar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(169, 9);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(88, 9);
            btnAlterar.Margin = new Padding(4, 3, 4, 3);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(75, 23);
            btnAlterar.TabIndex = 2;
            btnAlterar.Text = "ALTERAR";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(250, 9);
            btnGravar.Margin = new Padding(4, 3, 4, 3);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 23);
            btnGravar.TabIndex = 1;
            btnGravar.Text = "GRAVAR";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(7, 9);
            btnNovo.Margin = new Padding(4, 3, 4, 3);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 23);
            btnNovo.TabIndex = 0;
            btnNovo.Text = "&NOVO";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabCadastro);
            tabControl.Controls.Add(tabConsulta);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Margin = new Padding(4, 3, 4, 3);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(548, 406);
            tabControl.TabIndex = 2;
            tabControl.Selecting += tabControl_Selecting;
            // 
            // tabCadastro
            // 
            tabCadastro.BackColor = Color.White;
            tabCadastro.Location = new Point(4, 24);
            tabCadastro.Margin = new Padding(4, 3, 4, 3);
            tabCadastro.Name = "tabCadastro";
            tabCadastro.Padding = new Padding(4, 3, 4, 3);
            tabCadastro.Size = new Size(540, 378);
            tabCadastro.TabIndex = 0;
            tabCadastro.Text = "Cadastro";
            // 
            // tabConsulta
            // 
            tabConsulta.Controls.Add(dataList);
            tabConsulta.Controls.Add(pnlPesquisa);
            tabConsulta.Location = new Point(4, 24);
            tabConsulta.Margin = new Padding(4, 3, 4, 3);
            tabConsulta.Name = "tabConsulta";
            tabConsulta.Padding = new Padding(4, 3, 4, 3);
            tabConsulta.Size = new Size(540, 378);
            tabConsulta.TabIndex = 1;
            tabConsulta.Text = "Consulta";
            tabConsulta.UseVisualStyleBackColor = true;
            // 
            // dataList
            // 
            dataList.AllowUserToOrderColumns = true;
            dataList.BackgroundColor = Color.White;
            dataList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataList.Dock = DockStyle.Fill;
            dataList.GridColor = SystemColors.ScrollBar;
            dataList.Location = new Point(4, 51);
            dataList.Margin = new Padding(4, 3, 4, 3);
            dataList.Name = "dataList";
            dataList.Size = new Size(532, 324);
            dataList.TabIndex = 1;
            // 
            // pnlPesquisa
            // 
            pnlPesquisa.Controls.Add(CBoxTodos);
            pnlPesquisa.Controls.Add(btnPesquisar);
            pnlPesquisa.Controls.Add(txtPesquisa);
            pnlPesquisa.Dock = DockStyle.Top;
            pnlPesquisa.Location = new Point(4, 3);
            pnlPesquisa.Margin = new Padding(4, 3, 4, 3);
            pnlPesquisa.Name = "pnlPesquisa";
            pnlPesquisa.Size = new Size(532, 48);
            pnlPesquisa.TabIndex = 0;
            // 
            // CBoxTodos
            // 
            CBoxTodos.AutoSize = true;
            CBoxTodos.Location = new Point(198, 15);
            CBoxTodos.Name = "CBoxTodos";
            CBoxTodos.Size = new Size(57, 19);
            CBoxTodos.TabIndex = 2;
            CBoxTodos.Text = "Todos";
            CBoxTodos.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(333, 14);
            btnPesquisar.Margin = new Padding(4, 3, 4, 3);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(99, 24);
            btnPesquisar.TabIndex = 1;
            btnPesquisar.Text = "PESQUISAR";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(4, 14);
            txtPesquisa.Margin = new Padding(4, 3, 4, 3);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(184, 23);
            txtPesquisa.TabIndex = 0;
            // 
            // TelaBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(548, 450);
            Controls.Add(tabControl);
            Controls.Add(pnlInferior);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaBase";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaBase";
            Load += TelaBase_Load;
            pnlInferior.ResumeLayout(false);
            tabControl.ResumeLayout(false);
            tabConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataList).EndInit();
            pnlPesquisa.ResumeLayout(false);
            pnlPesquisa.PerformLayout();
            ResumeLayout(false);
        }



        #endregion

        private Panel pnlInferior;
        private TabPage tabConsulta;
        private Panel pnlPesquisa;
        private Button btnNovo;
        private Button btnFechar;
        private Button btnApagar;
        private Button btnCancelar;
        private Button btnAlterar;
        private Button btnGravar;
        protected TabPage tabCadastro;
        protected TabControl tabControl;
        protected DataGridView dataList;
        protected Button btnPesquisar;
        protected CheckBox CBoxTodos;
        protected TextBox txtPesquisa;
    }


}