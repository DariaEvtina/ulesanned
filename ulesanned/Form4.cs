using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ulesanned
{
    public partial class Form4 : Form
    {
        int time;
        Timer timeLeft;
        Timer timer;
        Label firstClicked = null;
        Label secondClicked = null;
        TableLayoutPanel tlp;
        Random rnd=new Random();
        kasutaja kas=null;
        List<string> ICONS = new List<string>()
        {
            "!","!","N","N",",",",","k","k","b","b","v","v","w","w","z","z"
        };
        public Form4()
        {
            time = 0;
            this.Size = new Size(550, 550);
            this.Text = "sobitamise mäng";
            tlp = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.CornflowerBlue,
                CellBorderStyle=TableLayoutPanelCellBorderStyle.InsetDouble,
                ColumnCount = 4,
                RowCount = 4,
            };
            for (int j = 0; j < 4; j++)
            {
                tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
                for (int e = 0; e < 4; e++)
                {
                    tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
                }
            }
            int i = 0;
            while (i!=4)
            {
                for (int e = 0; e < 4; e++)
                {
                    Label lbl = new Label
                    {
                        BackColor = Color.CornflowerBlue,
                        AutoSize = false,
                        Dock = DockStyle.Fill,
                        TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                        Font = new Font("Arial", 48, FontStyle.Bold, (GraphicsUnit)ButtonBorderStyle.Solid, (byte)BorderType.Ellipse),
                        Text=""
                    };
                    lbl.Click += new System.EventHandler(Lbl_Click);
                    tlp.Controls.Add(lbl, i, e);
                }
                i++;
            }
            this.Controls.Add(tlp);
            timer = new Timer();
            timeLeft = new Timer();
            timeLeft.Tick += TimeLeft_Tick;
            timer.Tick += Timer_Tick;
            AssignIconsToSquares();
            timeLeft.Start();
        }
        public Form4(kasutaja kas)
        {
            this.kas = kas;
            time = 0;
            this.Size = new Size(550, 550);
            this.Text = "sobitamise mäng";
            tlp = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.CornflowerBlue,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble,
                ColumnCount = 4,
                RowCount = 4,
            };
            for (int j = 0; j < 4; j++)
            {
                tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
                for (int e = 0; e < 4; e++)
                {
                    tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
                }
            }
            int i = 0;
            while (i != 4)
            {
                for (int e = 0; e < 4; e++)
                {
                    Label lbl = new Label
                    {
                        BackColor = Color.CornflowerBlue,
                        AutoSize = false,
                        Dock = DockStyle.Fill,
                        TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                        Font = new Font("Arial", 48, FontStyle.Bold, (GraphicsUnit)ButtonBorderStyle.Solid, (byte)BorderType.Ellipse),
                        Text = ""
                    };
                    lbl.Click += new System.EventHandler(Lbl_Click);
                    tlp.Controls.Add(lbl, i, e);
                }
                i++;
            }
            this.Controls.Add(tlp);
            timer = new Timer();
            timeLeft = new Timer();
            timeLeft.Tick += TimeLeft_Tick;
            timer.Tick += Timer_Tick;
            AssignIconsToSquares();
            timeLeft.Start();
        }

        private void TimeLeft_Tick(object sender, EventArgs e)
        {
            time += 1;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();

            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            firstClicked = null;
            secondClicked = null;
        }

        private void Lbl_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                clickedLabel.ForeColor = Color.Black;
            }
            if (firstClicked == null)
            {
                firstClicked = clickedLabel;
                firstClicked.ForeColor = Color.Black;

                return;
            }
            secondClicked = clickedLabel;
            secondClicked.ForeColor = Color.Black;
            CheckForWinner();
            if (firstClicked.Text == secondClicked.Text)
            {
                firstClicked = null;
                secondClicked = null;
                return;
            }
            timer.Start();
        }

        private void AssignIconsToSquares()
        {
            // The TableLayoutPanel has 16 labels,
            // and the icon list has 16 icons,
            // so an icon is pulled at random from the list
            // and added to each label
            foreach (Control control in tlp.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = rnd.Next(ICONS.Count);
                    iconLabel.Text = ICONS[randomNumber];
                    // iconLabel.ForeColor = iconLabel.BackColor;
                    ICONS.RemoveAt(randomNumber);
                    iconLabel.ForeColor = iconLabel.BackColor;
                }
            }
        }
        private void CheckForWinner()
        {
            // Go through all of the labels in the TableLayoutPanel, 
            // checking each one to see if its icon is matched
            foreach (Control control in tlp.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }

            // If the loop didn’t return, it didn't find
            // any unmatched icons
            // That means the user won. Show a message and close the form
            if (kas!=null)
            {
                MessageBox.Show($"Sa sobitasid kõik ikoonid!{kas.nimi} sul on aeg: {time} sekondit", "palju õnne");
            }
            else
            {
                MessageBox.Show($"Sa sobitasid kõik ikoonid! Sul on aeg: {time} sekondit", "palju õnne");
            }
            timeLeft.Stop();
            ApplicationContext con = new ApplicationContext();
            rekordit rek = new rekordit();
            rek.mang = this.Text;
            rek.rekord = $"{time} sekondit";
            if (kas != null)
            {
                rek.kasutaja = kas.nimi + " " + kas.email;
            }
            else
            {
                rek.kasutaja = "külaline";
            }
            con.rekordit1.Add(rek);
            time = 0;
            Close();

        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
