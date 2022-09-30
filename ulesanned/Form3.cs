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
            }
            NumericUpDown Result_1 = new NumericUpDown { Size = new Size(60, 50), Font = new Font("Arial", 18) };
            Label v1_1 = new Label
            {
                Text = "?",
                Size = new Size(60, 50),
                Font = new Font("Arial", 18),
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label v2_1 = new Label
            {
                Text = "?",
                Size = new Size(60, 50),
                Font = new Font("Arial", 18),
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label sign_1 = new Label
            {
                Text = $"{sings[rnd.Next(0, 3)]}",
                Size = new Size(60, 50),
                Font = new Font("Arial", 18),
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label equel_1 = new Label
            {
                Text = "=",
                Size = new Size(60, 50),
                Font = new Font("Arial", 18),
                TextAlign = ContentAlignment.MiddleCenter
            };
            tlp.Controls.Add(v1_1, 0, 0);
            tlp.Controls.Add(sign_1, 1, 0);
            tlp.Controls.Add(v2_1, 2, 0);
            tlp.Controls.Add(equel_1, 3, 0);
            tlp.Controls.Add(Result_1, 4, 0);
            NumericUpDown Result = new NumericUpDown { Size = new Size(60, 50), Font = new Font("Arial", 18) };
            Label v1 = new Label
            {
                Text = "?",
                Size = new Size(60, 50),
                Font = new Font("Arial", 18),
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label v2 = new Label
            {
                Text = "?",
                Size = new Size(60, 50),
                Font = new Font("Arial", 18),
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label sign = new Label
            {
                Text = $"{sings[rnd.Next(0, 3)]}",
                Size = new Size(60, 50),
                Font = new Font("Arial", 18),
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label equel = new Label
            {
                Text = "=",
                Size = new Size(60, 50),
                Font = new Font("Arial", 18),
                TextAlign = ContentAlignment.MiddleCenter
            };
            tlp.Controls.Add(v1, 0, 1);
            tlp.Controls.Add(sign, 1, 1);
            tlp.Controls.Add(v2, 2, 1);
            tlp.Controls.Add(equel, 3, 1);
            tlp.Controls.Add(Result, 4, 1);
            NumericUpDown Result_ = new NumericUpDown { Size = new Size(60, 50), Font = new Font("Arial", 18) };
            Label v1_ = new Label
            {
                Text = "?",
                Size = new Size(60, 50),
                Font = new Font("Arial", 18),
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label v2_ = new Label
            {
                Text = "?",
                Size = new Size(60, 50),
                Font = new Font("Arial", 18),
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label sign_ = new Label
            {
                Text = $"{sings[rnd.Next(0, 3)]}",
                Size = new Size(60, 50),
                Font = new Font("Arial", 18),
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label equel_ = new Label
            {
                Text = "=",
                Size = new Size(60, 50),
                Font = new Font("Arial", 18),
                TextAlign = ContentAlignment.MiddleCenter
            };
            tlp.Controls.Add(v1_, 0, 2);
            tlp.Controls.Add(sign_, 1, 2);
            tlp.Controls.Add(v2_, 2, 2);
            tlp.Controls.Add(equel_, 3, 2);
            tlp.Controls.Add(Result_, 4, 2);
            NumericUpDown Result_2 = new NumericUpDown { Size = new Size(60, 50), Font = new Font("Arial", 18) };
            Label v1_2 = new Label
            {
                Text = "?",
                Size = new Size(60, 50),
                Font = new Font("Arial", 18),
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label v2_2 = new Label
            {
                Text = "?",
                Size = new Size(60, 50),
                Font = new Font("Arial", 18),
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label sign_2 = new Label
            {
                Text = $"{sings[rnd.Next(0, 3)]}",
                Size = new Size(60, 50),
                Font = new Font("Arial", 18),
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label equel_2 = new Label
            {
                Text = "=",
                Size = new Size(60, 50),
                Font = new Font("Arial", 18),
                TextAlign = ContentAlignment.MiddleCenter
            };
            tlp.Controls.Add(v1_2, 0, 3);
            tlp.Controls.Add(sign_2, 1, 3);
            tlp.Controls.Add(v2_2, 2, 3);
            tlp.Controls.Add(equel_2, 3, 3);
            tlp.Controls.Add(Result_2, 4, 3);
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
