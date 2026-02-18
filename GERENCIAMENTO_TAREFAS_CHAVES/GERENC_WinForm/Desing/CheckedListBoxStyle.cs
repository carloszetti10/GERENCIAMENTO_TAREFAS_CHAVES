using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GERENC_WinForm.Desing
{
    public static class CheckedListBoxStyle
    {
        public static void Apply(CheckedListBox clb)
        {
            clb.Font = new Font("Segoe UI", 10F);
            clb.BackColor = Color.White;
            clb.ForeColor = Color.FromArgb(33, 37, 41);
            clb.BorderStyle = BorderStyle.FixedSingle;
            clb.CheckOnClick = true;
            clb.ItemHeight = 22;
            clb.Cursor = Cursors.Hand;
        }
    }
 }
