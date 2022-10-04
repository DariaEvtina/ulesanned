using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
namespace ulesanned
{
    public partial class Form3 : Form
    {
        Button Start;
        Button Finish;
        Random rnd;
        Label Timelb;
        Label v1; Label v2; Label sign; Label equel; NumericUpDown Result;
        Label v1_; Label v2_; Label sign_; Label equel_; NumericUpDown Result_;
        Label v1_1; Label v2_1; Label sign_1; Label equel_1; NumericUpDown Result_1;
        Label v1_2; Label v2_2; Label sign_2; Label equel_2; NumericUpDown Result_2;
        Timer timer;
        int timeLeft=2000;
        char[] sings = new char[] { '-', '+', '/', '*' };
        public Form3()
        {
            this.Size = new Size(500, 400);
            this.Text = "MATH QUIZ";
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
            Start = new Button
            {
                Text="Start quiz",
                Location = new Point(200,325)
            };
            Finish = new Button
            {
                Text = "Finish quiz",
                Location = new Point(200, 325),
                Visible = false
            };
            rnd =new Random();
            for (int i = 0; i < 4; i++)
            {
                tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
                tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3F));
                tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3F));
                tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3F));
                tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3F));
                tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3F));
            }
            Result_1 = new NumericUpDown { Size = new Size(60, 50), Font = new Font("Arial", 18), Minimum = -20 };
            v1_1 = new Label
            {
                Text = "?",
                Size = new Size(60, 50),
                Font = new Font("Arial", 18),
                TextAlign = ContentAlignment.MiddleCenter
            };
            v2_1 = new Label
            {
                Text = "?",
                Size = new Size(60, 50),
                Font = new Font("Arial", 18),
                TextAlign = ContentAlignment.MiddleCenter
            };
            sign_1 = new Label
            {
                Text = $"{sings[rnd.Next(0, 3)]}",
                Size = new Size(60, 50),
                Font = new Font("Arial", 18),
                TextAlign = ContentAlignment.MiddleCenter
            };
            equel_1 = new Label
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
             Result = new NumericUpDown { Size = new Size(60, 50), Font = new Font("Arial", 18), Minimum = -20 };
             v1 = new Label
            {
                Text = "?",
                Size = new Size(60, 50),
                Font = new Font("Arial", 18),
                TextAlign = ContentAlignment.MiddleCenter
            };
             v2 = new Label
            {
                Text = "?",
                Size = new Size(60, 50),
                Font = new Font("Arial", 18),
                TextAlign = ContentAlignment.MiddleCenter
            };
             sign = new Label
            {
                Text = $"{sings[rnd.Next(0, 3)]}",
                Size = new Size(60, 50),
                Font = new Font("Arial", 18),
                TextAlign = ContentAlignment.MiddleCenter
            };
             equel = new Label
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
            Result_ = new NumericUpDown { Size = new Size(60, 50), Font = new Font("Arial", 18), Minimum = -20 };
             v1_ = new Label
            {
                Text = "?",
                Size = new Size(60, 50),
                Font = new Font("Arial", 18),
                TextAlign = ContentAlignment.MiddleCenter
            };
              v2_ = new Label
            {
                Text = "?",
                Size = new Size(60, 50),
                Font = new Font("Arial", 18),
                TextAlign = ContentAlignment.MiddleCenter
            };
              sign_ = new Label
            {
                Text = $"{sings[rnd.Next(0, 3)]}",
                Size = new Size(60, 50),
                Font = new Font("Arial", 18),
                TextAlign = ContentAlignment.MiddleCenter
            };
              equel_ = new Label
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
            Result_2 = new NumericUpDown { Size = new Size(60, 50), Font = new Font("Arial", 18),Minimum=-20 };
              v1_2 = new Label
            {
                Text = "?",
                Size = new Size(60, 50),
                Font = new Font("Arial", 18),
                TextAlign = ContentAlignment.MiddleCenter
            };
              v2_2 = new Label
            {
                Text = "?",
                Size = new Size(60, 50),
                Font = new Font("Arial", 18),
                TextAlign = ContentAlignment.MiddleCenter
            };
              sign_2 = new Label
            {
                Text = $"{sings[rnd.Next(0, 3)]}",
                Size = new Size(60, 50),
                Font = new Font("Arial", 18),
                TextAlign = ContentAlignment.MiddleCenter
            };
              equel_2 = new Label
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
            Start.Click += Start_Click;
            Finish.Click += Finish_Click;
            timer = new Timer();
            timer.Tick += Timer_Tick;
            this.Controls.Add(tlp);
            this.Controls.Add(Finish);
            this.Controls.Add(Start);
            this.Controls.Add(Timelb);
            this.Controls.Add(lb);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                Timelb.Text = timeLeft + " seconds";
            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                timer.Stop();
                Timelb.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
            }
        }

        public void check()
        {
            if (sign.Text=="+")
            {
                if (Result.Value == Convert.ToInt32(v1.Text) + Convert.ToInt32(v2.Text))
                {
                    Result.BackColor = Color.Green;
                }
                else if (Result.Value != Convert.ToInt32(v1.Text) + Convert.ToInt32(v2.Text))
                {
                    Result.BackColor = Color.Red;
                }
            }
            else if (sign.Text == "-")
            {
                if (Result.Value == Convert.ToInt32(v1.Text) - Convert.ToInt32(v2.Text))
                {
                    Result.BackColor = Color.Green;
                }
                else if (Result.Value != Convert.ToInt32(v1.Text) - Convert.ToInt32(v2.Text))
                {
                    Result.BackColor = Color.Red;
                }
            }
            else if (sign.Text == "/")
            {
                if (Result.Value == Math.Abs(Convert.ToInt32(v1.Text) / Convert.ToInt32(v2.Text)))
                {
                    Result.BackColor = Color.Green;
                }
                else if (Result.Value != Math.Abs(Convert.ToInt32(v1.Text) / Convert.ToInt32(v2.Text)))
                {
                    Result.BackColor = Color.Red;
                }
            }
            else if (sign.Text == "*")
            {
                if (Result.Value == Math.Abs(Convert.ToInt32(v1.Text) * Convert.ToInt32(v2.Text)))
                {
                    Result.BackColor = Color.Green;
                }
                else if (Result.Value != Math.Abs(Convert.ToInt32(v1.Text) * Convert.ToInt32(v2.Text)))
                {
                    Result.BackColor = Color.Red;
                }
            }
            ////////
            if (sign_.Text == "+")
            {
                if (Result_.Value == Convert.ToInt32(v1_.Text) + Convert.ToInt32(v2_.Text))
                {
                    Result_.BackColor = Color.Green;
                }
                else if (Result_.Value != Convert.ToInt32(v1_.Text) + Convert.ToInt32(v2_.Text))
                {
                    Result_.BackColor = Color.Red;
                }
            }
            else if (sign_.Text == "-")
            {
                if (Result_.Value == Convert.ToInt32(v1_.Text) - Convert.ToInt32(v2_.Text))
                {
                    Result_.BackColor = Color.Green;
                }
                else if (Result_.Value !=Convert.ToInt32(v1_.Text) - Convert.ToInt32(v2_.Text))
                {
                    Result_.BackColor = Color.Red;
                }
            }
            else if (sign_.Text == "/")
            {
                if (Result_.Value == Math.Abs(Convert.ToInt32(v1_.Text) / Convert.ToInt32(v2_.Text)))
                {
                    Result_.BackColor = Color.Green;
                }
                else if (Result_.Value != Math.Abs(Convert.ToInt32(v1_.Text) / Convert.ToInt32(v2_.Text)))
                {
                    Result_.BackColor = Color.Red;
                }
            }
            else if (sign_.Text == "*")
            {
                if (Result_.Value == Math.Abs(Convert.ToInt32(v1_.Text) * Convert.ToInt32(v2_.Text)))
                {
                    Result_.BackColor = Color.Green;
                }
                else if (Result_.Value != Math.Abs(Convert.ToInt32(v1_.Text) * Convert.ToInt32(v2_.Text)))
                {
                    Result_.BackColor = Color.Red;
                }
            }
            ////////
            if (sign_1.Text == "+")
            {
                if (Result_1.Value == Convert.ToInt32(v1_1.Text) + Convert.ToInt32(v2_1.Text))
                {
                    Result_1.BackColor = Color.Green;
                }
                else if (Result_1.Value != Convert.ToInt32(v1_1.Text) + Convert.ToInt32(v2_1.Text))
                {
                    Result_1.BackColor = Color.Red;
                }
            }
            else if (sign_1.Text == "-")
            {
                if (Result_1.Value == Convert.ToInt32(v1_1.Text) - Convert.ToInt32(v2_1.Text))
                {
                    Result_1.BackColor = Color.Green;
                }
                else if (Result_1.Value != Convert.ToInt32(v1_1.Text) - Convert.ToInt32(v2_1.Text))
                {
                    Result_1.BackColor = Color.Red;
                }
            }
            else if (sign_1.Text == "/")
            {
                if (Result_1.Value == Math.Abs(Convert.ToInt32(v1_1.Text) / Convert.ToInt32(v2_1.Text)))
                {
                    Result_1.BackColor = Color.Green;
                }
                else if (Result_1.Value != Math.Abs(Convert.ToInt32(v1_1.Text) / Convert.ToInt32(v2_1.Text)))
                {
                    Result_1.BackColor = Color.Red;
                }
            }
            else if (sign_1.Text == "*")
            {
                if (Result_1.Value == Math.Abs(Convert.ToInt32(v1_1.Text) * Convert.ToInt32(v2_1.Text)))
                {
                    Result_1.BackColor = Color.Green;
                }
                else if (Result_1.Value != Math.Abs(Convert.ToInt32(v1_1.Text) * Convert.ToInt32(v2_1.Text)))
                {
                    Result_1.BackColor = Color.Red;
                }
            }
            ////////
            if (sign_2.Text == "+")
            {
                if (Result_2.Value == Convert.ToInt32(v1_2.Text) + Convert.ToInt32(v2_2.Text))
                {
                    Result_2.BackColor = Color.Green;
                }
                else if (Result_2.Value != Convert.ToInt32(v1_2.Text) + Convert.ToInt32(v2_2.Text))
                {
                    Result_2.BackColor = Color.Red;
                }
            }
            else if (sign_2.Text == "-")
            {
                if (Result_2.Value == Convert.ToInt32(v1_2.Text) - Convert.ToInt32(v2_2.Text))
                {
                    Result_2.BackColor = Color.Green;
                }
                else if (Result_2.Value != Convert.ToInt32(v1_2.Text) - Convert.ToInt32(v2_2.Text))
                {
                    Result_2.BackColor = Color.Red;
                }
            }
            else if (sign_2.Text == "/")
            {
                if (Result_2.Value == Math.Abs(Convert.ToInt32(v1_2.Text) / Convert.ToInt32(v2_2.Text)))
                {
                    Result_2.BackColor = Color.Green;
                }
                else if (Result_2.Value != Math.Abs(Convert.ToInt32(v1_2.Text) / Convert.ToInt32(v2_2.Text)))
                {
                    Result_2.BackColor = Color.Red;
                }
            }
            else if (sign_2.Text == "*")
            {
                if (Result_2.Value == Math.Abs(Convert.ToInt32(v1_2.Text) * Convert.ToInt32(v2_2.Text)))
                {
                    Result_2.BackColor = Color.Green;
                }
                else if (Result_2.Value != Math.Abs(Convert.ToInt32(v1_2.Text) * Convert.ToInt32(v2_2.Text)))
                {
                    Result_2.BackColor = Color.Red;
                }
            }
        }
        private void Finish_Click(object sender, EventArgs e)
        {
            Finish.Visible = false;
            Start.Visible = true;
            check();
            timer.Stop();
        }

        public void StartQuz()
        {
            timeLeft = 2000;
            timer.Start();
            Result.BackColor = Color.White;
            Result_.BackColor = Color.White;
            Result_1.BackColor = Color.White;
            Result_2.BackColor = Color.White;
            v1.Text = rnd.Next(1, 20).ToString();
            v1_.Text = rnd.Next(1, 20).ToString();
            v1_1.Text = rnd.Next(1, 20).ToString();
            v1_2.Text = rnd.Next(1, 20).ToString();
            v2.Text = rnd.Next(1, 20).ToString();
            v2_.Text = rnd.Next(1, 20).ToString();
            v2_1.Text = rnd.Next(1, 20).ToString();
            v2_2.Text = rnd.Next(1, 20).ToString();
        }
        private void Start_Click(object sender, EventArgs e)
        {
            StartQuz();
            Start.Visible = false;
            Finish.Visible = true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
