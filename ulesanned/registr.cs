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
        //C:\Users\opilane\source\repos\dariaEvtinaTARpv20\ulesanned\ulesanned\img\1.jpg
        PictureBox pb;
        TextBox username;
        TextBox password;
        TextBox email;
        RadioButton mees;
        RadioButton naine;
        NumericUpDown dtp;
        string sugu;
        string avatar=@"..\..\avatar.png";
        public registr()
        {
            this.Text = "registrerimine vorm";
            this.Size = new Size(300, 460);
            dtp= new NumericUpDown
            { 
                Size = new Size(100, 20),
                Maximum=116
            };
            Label lbl = new Label
            {
                Text="vanus",
            };
            mees = new RadioButton
            {
                Text="mees"
            };
            naine = new RadioButton
            {
                Text = "naine"
            };
            mees.CheckedChanged += new System.EventHandler(Mees_CheckedChanged);
            naine.CheckedChanged += new System.EventHandler(Mees_CheckedChanged);
            Label pass = new Label
            {
                Text = "salasõna",
                Size = new Size(50, 20),
                Location = new Point(10, 143)
            };
            Label e_post = new Label
            {
                Text = "e-post",
                Size = new Size(50, 20),
                Location = new Point(10, 143)
            };
            Label name = new Label
            {
                Text = "nimi",
                Size = new Size(90, 20),
                Location = new Point(10, 173),
            };
            pb = new PictureBox
            {
                Size = new Size(120, 120),
                Location = new Point(80, 10),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            pb.Load(@"..\..\img\avatar.png");
            username = new TextBox
            {
                Size = new Size(150, 10),
                Location = new Point(100, 140),
                
            };
            email = new TextBox
            {
                Size = new Size(150, 10),
                Location = new Point(100, 140),

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
            TableLayoutPanel tlp = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = 7,
                ColumnCount = 2,
            };
            Button load_img = new Button
            {
                Text="lisa pilt"
            };
            load_img.Click += Load_img_Click;
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlp.Controls.Add(pb, 0, 0);
            tlp.Controls.Add(load_img, 1, 0);
            tlp.Controls.Add(name,0,1);
            tlp.Controls.Add(username, 1, 1);
            tlp.Controls.Add(pass, 0, 2);
            tlp.Controls.Add(password, 1, 2);
            tlp.Controls.Add(naine, 0, 3);
            tlp.Controls.Add(mees, 1, 3);
            tlp.Controls.Add(lbl, 0, 4);
            tlp.Controls.Add(dtp, 1, 4);
            tlp.Controls.Add(e_post, 0, 5);
            tlp.Controls.Add(email, 1, 5);
            tlp.Controls.Add(reg, 0, 6);
            tlp.Controls.Add(log, 1, 6);
            reg.Click += Reg_Click;
            log.Click += Log_Click;
            this.Controls.Add(tlp);
        }

        private void Load_img_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPEG Files(*.jpg) | *.jpg | PNG Files(*.png) | *.png | BMP Files(*.bmp) | *.bmp | All files(*.*) | *.*";
            ofd.Title = "Select a picture file";
            ofd.ShowDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pb.Load(ofd.FileName);
                avatar = ofd.FileName;
            }
        }

        private void Mees_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton sugu_checked= (RadioButton) sender;
            sugu=sugu_checked.Text;
        }

        private void Log_Click(object sender, EventArgs e)
        {
            login log = new login();
            this.Close();
            log.Show();
        }

        private void Reg_Click(object sender, EventArgs e)
        {
            ApplicationContext con = new ApplicationContext();
            kasutaja uss_konto = new kasutaja();
            uss_konto.nimi=username.Text.Trim();
            uss_konto.salasona=password.Text.Trim();
            uss_konto.sugu = sugu;
            uss_konto.vanus = (int)dtp.Value;
            uss_konto.email=email.Text.Trim();
            uss_konto.avatar = avatar;
            uss_konto.isadmin = 0;
            con.kasutajad1.Add(uss_konto);
            con.SaveChangesAsync();
            MessageBox.Show($"Nimi {username.Text.Trim()} pass: {password.Text.Trim()} Sugu: {sugu} Vanus: {dtp.Value} Avatr: {avatar}");
        }
    

        private void registr_Load(object sender, EventArgs e)
        {

        }
    }
}
