using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ulesanned
{
    public partial class Form2 : Form
    {
        System.Windows.Forms.CheckBox cb;
        PictureBox pc;
        public Form2()
        {
            this.Size = new Size(700, 500);
            this.Text = "PICTURE VIEWER";
            this.MaximizeBox = false;
            TableLayoutPanel tlp = new TableLayoutPanel
            {
                AutoSize = true,
                Size = new Size(700, 500),
                Location = new Point(0,0),
                ColumnCount = 2,
                RowCount = 2
            };
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent,15F));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tlp.RowStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tlp.RowStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pc = new PictureBox
            {
                BorderStyle=BorderStyle.Fixed3D,
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };
            cb = new System.Windows.Forms.CheckBox
            {
                Text="Strech"
            };
            cb.CheckedChanged += Cb_CheckedChanged;
            Button close = new Button
            {
                Text="Close",
                BackColor = Color.White

            };
            close.Click += new System.EventHandler(btn_Click);
            Button bc = new Button
            {
                Text = "Set Backgroung color",
                Size = new Size(140,25),
                BackColor = Color.White

            };
            bc.Click += new System.EventHandler(btn_Click);
            Button clear = new Button
            {
                Text = "Clear the picture",
                Size = new Size(110, 25),
                BackColor = Color.White

            };
            clear.Click += new System.EventHandler(btn_Click);
            Button show = new Button
            {
                Text = "Show a picture",
                Size = new Size(110, 25),
                BackColor = Color.White

            };
            show.Click += new System.EventHandler(btn_Click);
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

        private void Cb_CheckedChanged(object sender, EventArgs e)
        {
            if (cb.Checked)
                pc.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pc.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button click =(Button) sender;
            if (click.Text== "Set Backgroung color")
            {
                ColorDialog cd = new ColorDialog();
                cd.ShowDialog();
                this.BackColor = cd.Color;
            }
            else if (click.Text == "Clear the picture")
            {
                pc.Image = null;
            }
            else if (click.Text == "Show a picture")
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "JPEG Files(*.jpg) | *.jpg | PNG Files(*.png) | *.png | BMP Files(*.bmp) | *.bmp | All files(*.*) | *.*";
                ofd.Title = "Select a picture file";
                ofd.ShowDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pc.Load(ofd.FileName);
                }


            }
            else if (click.Text == "Close")
            {
                this.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
