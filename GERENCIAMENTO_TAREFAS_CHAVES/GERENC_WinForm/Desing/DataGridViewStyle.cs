using System.Drawing;
using System.Windows.Forms;

public static class DataGridViewStyle
{
    public static void Apply(DataGridView dgv)
    {
        // remover bordas
        dgv.BorderStyle = BorderStyle.None;
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

        // cores gerais
        dgv.BackgroundColor = Color.White;
        dgv.GridColor = Color.FromArgb(230, 230, 230);

        // cabeçalho
        dgv.EnableHeadersVisualStyles = false;
        dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        dgv.ColumnHeadersHeight = 40;

        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 37, 41);
        dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(33, 37, 41);
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        

        // células
        dgv.DefaultCellStyle.BackColor = Color.White;
        dgv.DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
        dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(77, 163, 255);
        dgv.DefaultCellStyle.SelectionForeColor = Color.White;

        // linhas alternadas
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);

        // linha selecionada
        dgv.RowTemplate.Height = 35;

        // remover seleção azul feia da esquerda
        dgv.RowHeadersVisible = false;

        // preencher largura
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        // seleção linha inteira
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        // desabilitar multi seleção
        dgv.MultiSelect = false;

        // somente leitura (opcional)
        dgv.ReadOnly = true;


        // seleção em cinza bem claro
        dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 235, 235);
        dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
    }

    public static void SetIDSmall(DataGridView dgv)
    {
        if (dgv.Columns.Count > 0)
        {
            dgv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgv.Columns[0].Width = 50;
        }
    }


    public static void ApplyT(TabControl tab)
    {
        tab.DrawMode = TabDrawMode.OwnerDrawFixed;
        tab.Appearance = TabAppearance.Normal;
        tab.ItemSize = new Size(100, 20);
        tab.SizeMode = TabSizeMode.Fixed;

        tab.DrawItem += (sender, e) =>
        {
            TabControl tc = (TabControl)sender;
            TabPage tp = tc.TabPages[e.Index];
            Rectangle rect = e.Bounds;

            bool selecionado = (e.State & DrawItemState.Selected) == DrawItemState.Selected;

            Color corFundo = selecionado
                ? Color.FromArgb(33, 37, 41)   // aba selecionada
                : Color.FromArgb(240, 240, 240); // aba normal

            Color corTexto = selecionado
                ? Color.White
                : Color.Black;

            using (SolidBrush br = new SolidBrush(corFundo))
            {
                e.Graphics.FillRectangle(br, rect);
            }

            TextRenderer.DrawText(
                e.Graphics,
                tp.Text,
                new Font("Segoe UI", 9F, FontStyle.Bold),
                rect,
                corTexto,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
            );
        };
    }

}
