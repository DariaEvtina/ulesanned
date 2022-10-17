using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ulesanned
{
    public partial class admin : Form
    {
        DataGridView dgv;
        public admin()
        {
            this.Text = "admin vorm";
            this.Size = new Size(900, 500);
            TableLayoutPanel tlp = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = 2,
                ColumnCount = 2,
            };
            dgv=new DataGridView();
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            this.Controls.Add(tlp);
        }

        private void admin_Load(object sender, EventArgs e)
        {

        }
    }
}
