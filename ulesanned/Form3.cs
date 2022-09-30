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
    public partial class Form3 : Form
    {
        Random rnd;
        Label Timelb;
        char[] sings = new char[] { '-', '+', '/', '*' };
        public Form3()
        {
            this.Size = new Size(500, 400);
            this.Text = "ulesanne #2";
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            Timelb = new Label
            {
                AutoSize=false,
                BorderStyle=BorderStyle.FixedSingle,
                Size=new Size(200,30),
                Location=new Point(275,10),
                Font =new Font("Arial",16)
            };
            Label lb = new Label
            {
                Text="Time Left",
                Size = new Size(150, 30),
                Location = new Point(165, 10),
                Font = new Font("Arial", 16)
            };
            TableLayoutPanel tlp = new TableLayoutPanel
            {
                AutoSize = true,
                Size = new Size(100, 270),
                Location = new Point(80, 50),
                ColumnCount = 5,
                RowCount = 4,
                BackColor = Color.White,
            };
            Button Start = new Button
            {
                Text="Start quiz",
                Location = new Point(200,325)
            };
            rnd=new Random();
            for (int i = 0; i < 4; i++)
            {
                tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
                tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3F));
                tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3F));
                tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3F));
                tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3F));
                tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3F));
                NumericUpDown Result = new NumericUpDown { Size = new Size(60, 50),Font = new Font("Arial", 18)};
                Label v1 = new Label {Text="?",Size = new Size(60, 50),
                    Font = new Font("Arial", 18),
                    TextAlign = ContentAlignment.MiddleCenter
                };
                Label v2 = new Label { Text = "?",
                    Size = new Size(60, 50),
                    Font = new Font("Arial", 18),
                    TextAlign = ContentAlignment.MiddleCenter
                };
                Label sign = new Label { Text = $"{sings[rnd.Next(0,3)]}",
                    Size = new Size(60, 50),
                    Font = new Font("Arial", 18),
                    TextAlign = ContentAlignment.MiddleCenter
                };
                Label equel = new Label { Text = "=",
                    Size = new Size(60, 50),
                    Font = new Font("Arial", 18),
                    TextAlign = ContentAlignment.MiddleCenter
                };
                tlp.Controls.Add(v1,0,i);
                tlp.Controls.Add(sign, 1, i);
                tlp.Controls.Add(v2, 2, i);
                tlp.Controls.Add(equel, 3, i);
                tlp.Controls.Add(Result, 4, i);
            }
            this.Controls.Add(tlp);
            this.Controls.Add(Start);
            this.Controls.Add(Timelb);
            this.Controls.Add(lb);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
