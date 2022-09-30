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
        Label Timelb;
        Label Value1;
        Label Value2;
        Label Sign;
        NumericUpDown Result;
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
            /*Value1 = new Label
            {
                Text="?",
                AutoSize=false,
                Size=new Size(60,50),
                Font = new Font("Arial", 18),
                TextAlign=ContentAlignment.MiddleCenter,
                Location=new Point(50,75)
            };
            Sign = new Label
            {
                Text = "+",
                AutoSize = false,
                Size = new Size(60, 50),
                Font = new Font("Arial", 18),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(110, 75)
            };
           Value2 = new Label
            {
                Text = "?",
                AutoSize = false,
                Size = new Size(60, 50),
                Font = new Font("Arial", 18),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(170, 75)
            };
            Label Equel = new Label
            {
                Text = "=",
                AutoSize = false,
                Size = new Size(60, 50),
                Font = new Font("Arial", 18),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(230, 75)
            };
            Result = new NumericUpDown
            {
                AutoSize = false,
                Size = new Size(100, 50),
                Font = new Font("Arial", 18),
                Location = new Point(310, 75)
            };
            this.Controls.Add(Value2); 
            this.Controls.Add(Value1);
            this.Controls.Add(Sign);
            this.Controls.Add(Equel);
            this.Controls.Add(Result);*/
            TableLayoutPanel tlp = new TableLayoutPanel
            {
                AutoSize = true,
                Size = new Size(500, 300),
                Location = new Point(0, 40),
                ColumnCount = 4,
                RowCount = 4,
                BackColor = Color.White,
            };
            /*for (int i = 0; i < 4; i++)
            {

            }*/
            this.Controls.Add(tlp);
            this.Controls.Add(Timelb);
            this.Controls.Add(lb);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
