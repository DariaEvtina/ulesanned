using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ulesanned
{
    public partial class registr : Form
    {
        TextBox username;
        TextBox password;
        RadioButton mees;
        RadioButton naine;
        DateTimePicker dtp;
        public registr()
        {
            this.Text = "registrerimine vorm";
            this.Size = new Size(300, 460);
            dtp= new DateTimePicker 
            { 
                Location = new Point(50,240)
            };  
            mees = new RadioButton
            {
                Text="mees"
            };
            naine = new RadioButton
            {
                Text = "naine"
            };
            RadioButton[] sugu = new RadioButton[] { mees, naine };
            FlowLayoutPanel flp = new FlowLayoutPanel
            {
                Size=new Size(280,30),
                Location=new Point(10,190)
            };
            flp.Controls.AddRange(sugu);
            Label pass = new Label
            {
                Text = "nimi",
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
                Size = new Size(120, 120),
                Location = new Point(80, 10),
            };
            pb.Load(@"..\..\img\avatar.png");
            username = new TextBox
            {
                Size = new Size(150, 10),
                Location = new Point(100, 140)
            };
            password = new TextBox
            {
                Size = new Size(150, 10),
                Location = new Point(100, 170),
                PasswordChar = '°'
            };
            Button reg = new Button
            {
                Text = "regiistrerii uus konto",
                Size = new Size(150, 50),
                Location = new Point(70, 290),
            };
            Button log = new Button
            {
                Text = "või logi sisse",
                Size = new Size(150, 50),
                Location = new Point(70, 350),
            };
            this.Controls.Add(pass);
            this.Controls.Add(name);
            this.Controls.Add(username);
            this.Controls.Add(password);
            this.Controls.Add(reg);
            this.Controls.Add(log);
            this.Controls.Add(flp);
            reg.Click += Reg_Click;
            log.Click += Log_Click;
            this.Controls.Add(pb);
            this.Controls.Add(dtp);
        }

        private void Log_Click(object sender, EventArgs e)
        {
            login log = new login();
            this.Close();
            log.Show();
        }

        private void Reg_Click(object sender, EventArgs e)
        {

        }
    

        private void registr_Load(object sender, EventArgs e)
        {

        }
    }
}
