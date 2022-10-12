using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ulesanned
{
    public partial class login : Form
    {
        TextBox username;
        TextBox password;
        kasutaja kas=null;
        public login()
        {
            this.Text = "login vorm";
            this.Size= new Size(350,300);
            Label pass=new Label
            {
                Text= "salasõna",
                Size = new Size(50, 20),
                Location = new Point(10, 143)
            };
            Label name = new Label
            {
                Text = "e-post",
                Size = new Size(90, 20),
                Location = new Point(10, 173),
            };
            PictureBox pb = new PictureBox
            {
               Size= new Size(120,120),
               Location=new Point(80,10),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            pb.Load(@"..\..\img\avatar.png");
            username = new TextBox
            {
                Size = new Size(150,10),
                Location=new Point(100, 140)
            };
            password = new TextBox
            {
                Size = new Size(150, 10),
                Location = new Point(100, 170),
                PasswordChar = '°'
            };
            Button reg = new Button
            {
                Text="või regiistreri uus konto",
                Size = new Size(150, 50),
                Location = new Point(70, 280),
            };
            Button log = new Button
            {
                Text = "logi sisse",
                Size = new Size(150, 50),
                Location = new Point(70, 200),
            };
            TableLayoutPanel tlp = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = 4,
                ColumnCount = 2,
            };
            tlp.Controls.Add(pb,0,0);
            tlp.Controls.Add(name, 0, 1);
            tlp.Controls.Add(pass, 0, 2);
            tlp.Controls.Add(username, 1, 1);
            tlp.Controls.Add(password, 1, 2);
            tlp.Controls.Add(reg, 1, 3);
            tlp.Controls.Add(log, 0, 3);
            this.Controls.Add(tlp);
            reg.Click += Reg_Click;
            log.Click += Log_Click;
        }

        private void Log_Click(object sender, EventArgs e)
        {
            ApplicationContext con = new ApplicationContext();
            /*foreach (kasutaja kas in con.kasutajad1)
            {
                if (kas.email==username.Text.Trim() && kas.salasona==password.Text.Trim())
                {
                    this.Close();
                    this.kas = kas;
                    Form1 w = new Form1(kas);
                    w.Show();
                }
            }*/

            foreach (kasutaja kas in con.kasutajad1)
            {
                if (kas.email == username.Text.Trim() && kas.salasona==password.Text.Trim())
                {
                    this.Close();
                    this.kas = kas;
                    Form1 w = new Form1(kas);
                    w.Show();
                }
            }
            if(kas==null)
            {
                MessageBox.Show("Kasutaja ei leinud", "error");
            }

        }

        private void Reg_Click(object sender, EventArgs e)
        {
            registr reg = new registr();
            this.Close();
            reg.Show();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
