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
    public partial class Form2 : Form
    {
        public Form2()
        {
            this.Size = new Size(700, 500);
            this.Text = "ulesanne #1";
            TableLayoutPanel tlp = new TableLayoutPanel
            {
                AutoSize = true,
                Size = new Size(700, 500),
                Location = new Point(0,0),
                ColumnCount = 2,
                RowCount = 2,
            };
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent,15F));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tlp.RowStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tlp.RowStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            PictureBox pc = new PictureBox
            {
                BorderStyle=BorderStyle.Fixed3D,
                Dock = DockStyle.Fill
            };
            CheckBox cb = new CheckBox
            {
                Text="Strech"
            };
            Button close = new Button
            {
                Text="Close"

            };
            Button bc = new Button
            {
                Text = "Set Backgroung color",
                Size = new Size(140,25)

            };
            Button clear = new Button
            {
                Text = "Clear the picture",
                Size = new Size(110, 25)

            };
            Button show = new Button
            {
                Text = "Show a picture",
                Size = new Size(110, 25)

            };
            Button[] range = new Button[] {close,bc,clear,show};
            FlowLayoutPanel flp = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
            };
            flp.Controls.AddRange(range);
            tlp.Controls.Add(pc,1,0);
            tlp.Controls.Add(flp, 1, 1);
            tlp.Controls.Add(cb, 0, 1);
            this.Controls.Add(tlp); 
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
