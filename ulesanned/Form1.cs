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
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.Size = new Size(301,350);
            this.Text = "ÜLESANNEID";
            Button UL1 = new Button
            {
                Text="ulesanne #1",
                Size=new Size(285,50),
                Location =new Point(0,0)
            };
            Button UL3 = new Button
            {
                Text = "ulesanne #2",
                Size = new Size(285, 50),
                Location = new Point(0, 55)
            };
            Button UL2 = new Button
            {
                Text = "ulesanne #3",
                Size = new Size(285, 50),
                Location = new Point(0, 110)
            };
            UL1.Click += new System.EventHandler( UL_Click);
            UL2.Click += new System.EventHandler(UL_Click);
            UL3.Click += new System.EventHandler(UL_Click);
            this.Controls.Add(UL1);
            this.Controls.Add(UL2);
            this.Controls.Add(UL3);
        }

        public void UL_Click(object sender, EventArgs e)
        {
            Button btn_click = (Button)sender;
            if (btn_click.Text== "ulesanne #1")
            {
                Form2 ul1 = new Form2();
                ul1.Show();
            }
            else if (btn_click.Text == "ulesanne #2")
            {
                Form3 ul2 = new Form3();
                ul2.Show();
            }
            else if (btn_click.Text == "ulesanne #3")
            {
                Form4 ul3 = new Form4();
                ul3.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
