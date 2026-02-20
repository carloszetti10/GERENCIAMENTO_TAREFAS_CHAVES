
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnlInferior = new Panel();
            btnFechar = new Button();
            btnCancelar = new Button();
            btnGravar = new Button();
            btnApagar = new Button();
            btnAlterar = new Button();
            btnNovo = new Button();
            tabControl = new TabControl();
            tabCadastro = new TabPage();
            pncCadBase = new Panel();
            tabConsulta = new TabPage();
            dataList = new DataGridView();
            panel1 = new Panel();
            pnlPesquisa = new Panel();
            CBoxTodos = new CheckBox();
            btnPesquisar = new Button();
            txtPesquisa = new TextBox();
            pnlInferior.SuspendLayout();
            tabControl.SuspendLayout();
            tabCadastro.SuspendLayout();
            pncCadBase.SuspendLayout();
            tabConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataList).BeginInit();
            panel1.SuspendLayout();
            pnlPesquisa.SuspendLayout();
            SuspendLayout();
            // 
            // pnlInferior
            // 
            pnlInferior.Controls.Add(btnFechar);
            pnlInferior.Controls.Add(btnCancelar);
            pnlInferior.Controls.Add(btnGravar);
            pnlInferior.Dock = DockStyle.Bottom;
            pnlInferior.Location = new Point(0, 412);
            pnlInferior.Margin = new Padding(4, 3, 4, 3);
            pnlInferior.Name = "pnlInferior";
            pnlInferior.Size = new Size(529, 38);
            pnlInferior.TabIndex = 0;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(446, 6);
            btnFechar.Margin = new Padding(4, 3, 4, 3);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 23);
            btnFechar.TabIndex = 5;
            btnFechar.Text = "FECHAR";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(104, 6);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(83, 23);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(13, 6);
            btnGravar.Margin = new Padding(4, 3, 4, 3);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(83, 23);
            btnGravar.TabIndex = 1;
            btnGravar.Text = "GRAVAR";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnApagar
            // 
            btnApagar.Location = new Point(96, 6);
            btnApagar.Margin = new Padding(4, 3, 4, 3);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(83, 23);
            btnApagar.TabIndex = 4;
            btnApagar.Text = "APAGAR";
            btnApagar.UseVisualStyleBackColor = true;
            btnApagar.Click += btnApagar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(5, 6);
            btnAlterar.Margin = new Padding(4, 3, 4, 3);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(83, 23);
            btnAlterar.TabIndex = 2;
            btnAlterar.Text = "ALTERAR";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(5, 3);
            btnNovo.Margin = new Padding(4, 3, 4, 3);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(83, 23);
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
            tabControl.Size = new Size(529, 412);
            tabControl.TabIndex = 2;
            tabControl.Selecting += tabControl_Selecting;
            // 
            // tabCadastro
            // 
            tabCadastro.BackColor = Color.White;
            tabCadastro.Controls.Add(pncCadBase);
            tabCadastro.Location = new Point(4, 24);
            tabCadastro.Margin = new Padding(4, 3, 4, 3);
            tabCadastro.Name = "tabCadastro";
            tabCadastro.Padding = new Padding(4, 3, 4, 3);
            tabCadastro.Size = new Size(521, 384);
            tabCadastro.TabIndex = 0;
            tabCadastro.Text = "Cadastro";
            // 
            // pncCadBase
            // 
            pncCadBase.BackColor = Color.LightGray;
            pncCadBase.Controls.Add(btnNovo);
            pncCadBase.Dock = DockStyle.Bottom;
            pncCadBase.Location = new Point(4, 353);
            pncCadBase.Name = "pncCadBase";
            pncCadBase.Size = new Size(513, 28);
            pncCadBase.TabIndex = 0;
            // 
            // tabConsulta
            // 
            tabConsulta.Controls.Add(dataList);
            tabConsulta.Controls.Add(panel1);
            tabConsulta.Controls.Add(pnlPesquisa);
            tabConsulta.Location = new Point(4, 24);
            tabConsulta.Margin = new Padding(4, 3, 4, 3);
            tabConsulta.Name = "tabConsulta";
            tabConsulta.Padding = new Padding(4, 3, 4, 3);
            tabConsulta.Size = new Size(521, 384);
            tabConsulta.TabIndex = 1;
            tabConsulta.Text = "Consulta";
            tabConsulta.UseVisualStyleBackColor = true;
            // 
            // dataList
            // 
            dataList.AllowUserToOrderColumns = true;
            dataList.BackgroundColor = Color.White;
            dataList.BorderStyle = BorderStyle.None;
            dataList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataList.Dock = DockStyle.Fill;
            dataList.GridColor = SystemColors.ScrollBar;
            dataList.Location = new Point(4, 51);
            dataList.Margin = new Padding(4, 3, 4, 3);
            dataList.Name = "dataList";
            dataList.Size = new Size(513, 295);
            dataList.TabIndex = 2;
            dataList.CellDoubleClick += dataList_CellDoubleClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(btnAlterar);
            panel1.Controls.Add(btnApagar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(4, 346);
            panel1.Name = "panel1";
            panel1.Size = new Size(513, 35);
            panel1.TabIndex = 1;
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
            pnlPesquisa.Size = new Size(513, 48);
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
            ClientSize = new Size(529, 450);
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
            tabCadastro.ResumeLayout(false);
            pncCadBase.ResumeLayout(false);
            tabConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataList).EndInit();
            panel1.ResumeLayout(false);
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
        protected Button btnPesquisar;
        protected CheckBox CBoxTodos;
        protected TextBox txtPesquisa;
        protected Panel pncCadBase;
        protected DataGridView dataList;
        private Panel panel1;
    }


}