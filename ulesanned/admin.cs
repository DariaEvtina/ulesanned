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
        }

        private void admin_Load(object sender, EventArgs e)
        {

        }
    }
}
