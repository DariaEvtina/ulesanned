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

        public login()
        {
            this.Text = "login vorm";
            this.Size= new Size(300,400);
            Label pass=new Label
            {
                Text="nimi",
                Size = new Size(50, 20),
                Location = new Point(10, 143)
            };
            Label name = new Label
            {
                Text = "salasõna",
                Size = new Size(90, 20),
                Location = new Point(10, 173),
            };
            PictureBox pb = new PictureBox
            {
               Size= new Size(120,120),
               Location=new Point(80,10),
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
            this.Controls.Add(pass);
            this.Controls.Add(name);
            this.Controls.Add(username);
            this.Controls.Add(password);
            this.Controls.Add(reg);
            this.Controls.Add(log);
            reg.Click += Reg_Click;
            log.Click += Log_Click;
            this.Controls.Add(pb);
        }

        private void Log_Click(object sender, EventArgs e)
        {
            
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
