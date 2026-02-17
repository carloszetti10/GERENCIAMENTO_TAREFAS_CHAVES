namespace GERENC_WinForm.Cadastros.FormCadastros
{
    partial class FormCategoria
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
            label1 = new Label();
            TNomeCategoria = new TextBox();
            tabCadastro.SuspendLayout();
            tabControl.SuspendLayout();
            SuspendLayout();
            // 
            // tabCadastro
            // 
            tabCadastro.Controls.Add(TNomeCategoria);
            tabCadastro.Controls.Add(label1);
            tabCadastro.Margin = new Padding(5, 3, 5, 3);
            tabCadastro.Padding = new Padding(5, 3, 5, 3);
            tabCadastro.Size = new Size(536, 197);
            // 
            // tabControl
            // 
            tabControl.Margin = new Padding(5, 3, 5, 3);
            tabControl.Size = new Size(544, 225);
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
            btnPesquisar.Location = new Point(282, 14);
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // CBoxTodos
            // 
            CBoxTodos.CheckedChanged += CBoxTodos_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 36);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 0;
            label1.Text = "NOME CATEGORIA:";
            // 
            // TNomeCategoria
            // 
            TNomeCategoria.Location = new Point(72, 54);
            TNomeCategoria.Margin = new Padding(4, 3, 4, 3);
            TNomeCategoria.Name = "TNomeCategoria";
            TNomeCategoria.Size = new Size(400, 23);
            TNomeCategoria.TabIndex = 1;
            // 
            // FormCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 269);
            Margin = new Padding(5, 3, 5, 3);
            Name = "FormCategoria";
            Text = "FormCategoria";
            tabCadastro.ResumeLayout(false);
            tabCadastro.PerformLayout();
            tabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox TNomeCategoria;
        private Label label1;
    }
}