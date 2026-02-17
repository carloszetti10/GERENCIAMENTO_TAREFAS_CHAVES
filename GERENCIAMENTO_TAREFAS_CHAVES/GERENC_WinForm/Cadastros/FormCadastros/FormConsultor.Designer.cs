namespace GERENC_WinForm.Cadastros.FormCadastros
{
    partial class FormConsultor
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
            txtNomeInstrutor = new TextBox();
            nome = new Label();
            cpf = new Label();
            txtCpfInstrutor = new TextBox();
            groupBox1 = new GroupBox();
            checkedListCategoria = new CheckedListBox();
            tabCadastro.SuspendLayout();
            tabControl.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabCadastro
            // 
            tabCadastro.Controls.Add(groupBox1);
            tabCadastro.Controls.Add(cpf);
            tabCadastro.Controls.Add(txtCpfInstrutor);
            tabCadastro.Controls.Add(nome);
            tabCadastro.Controls.Add(txtNomeInstrutor);
            tabCadastro.Size = new Size(543, 378);
            tabCadastro.Controls.SetChildIndex(pncCadBase, 0);
            tabCadastro.Controls.SetChildIndex(txtNomeInstrutor, 0);
            tabCadastro.Controls.SetChildIndex(nome, 0);
            tabCadastro.Controls.SetChildIndex(txtCpfInstrutor, 0);
            tabCadastro.Controls.SetChildIndex(cpf, 0);
            tabCadastro.Controls.SetChildIndex(groupBox1, 0);
            // 
            // tabControl
            // 
            tabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl.ItemSize = new Size(100, 20);
            tabControl.Size = new Size(551, 406);
            tabControl.SizeMode = TabSizeMode.Fixed;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.FromArgb(0, 123, 255);
            btnPesquisar.FlatAppearance.BorderSize = 0;
            btnPesquisar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 90, 180);
            btnPesquisar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 105, 217);
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPesquisar.ForeColor = Color.White;
            btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // pncCadBase
            // 
            pncCadBase.Size = new Size(535, 28);
            // 
            // txtNomeInstrutor
            // 
            txtNomeInstrutor.Location = new Point(15, 49);
            txtNomeInstrutor.Name = "txtNomeInstrutor";
            txtNomeInstrutor.Size = new Size(366, 23);
            txtNomeInstrutor.TabIndex = 1;
            // 
            // nome
            // 
            nome.AutoSize = true;
            nome.Location = new Point(15, 31);
            nome.Name = "nome";
            nome.Size = new Size(43, 15);
            nome.TabIndex = 2;
            nome.Text = "Nome:";
            // 
            // cpf
            // 
            cpf.AutoSize = true;
            cpf.Location = new Point(15, 85);
            cpf.Name = "cpf";
            cpf.Size = new Size(43, 15);
            cpf.TabIndex = 4;
            cpf.Text = "Nome:";
            // 
            // txtCpfInstrutor
            // 
            txtCpfInstrutor.Location = new Point(15, 103);
            txtCpfInstrutor.Name = "txtCpfInstrutor";
            txtCpfInstrutor.Size = new Size(366, 23);
            txtCpfInstrutor.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkedListCategoria);
            groupBox1.Location = new Point(15, 141);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(366, 175);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Categorias";
            // 
            // checkedListCategoria
            // 
            checkedListCategoria.Dock = DockStyle.Fill;
            checkedListCategoria.FormattingEnabled = true;
            checkedListCategoria.Location = new Point(3, 19);
            checkedListCategoria.Name = "checkedListCategoria";
            checkedListCategoria.Size = new Size(360, 153);
            checkedListCategoria.TabIndex = 6;
            // 
            // FormConsultor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 450);
            Name = "FormConsultor";
            Text = "FormConsultor";
            tabCadastro.ResumeLayout(false);
            tabCadastro.PerformLayout();
            tabControl.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label cpf;
        private TextBox txtCpfInstrutor;
        private Label nome;
        private TextBox txtNomeInstrutor;
        private GroupBox groupBox1;
        private CheckedListBox checkedListCategoria;
    }
}