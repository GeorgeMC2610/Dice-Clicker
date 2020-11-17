using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_vathomologoumeni_1
{
    public partial class DiceClicker : Form
    {
        string[] Images = new string[6];
        short difficulty;
        short index = 0;
        int score = 0;
        int time = 60;
        

        public DiceClicker(short difficulty)
        {
            InitializeComponent();
            this.difficulty = difficulty;
        }

        private void DiceClicker_Load(object sender, EventArgs e)
        {
            Images[0] = "dice/dice1.png";
            Images[1] = "dice/dice2.png";
            Images[2] = "dice/dice3.png";
            Images[3] = "dice/dice4.png";
            Images[4] = "dice/dice5.png";
            Images[5] = "dice/dice6.png";
            label1.Text = "Time: 60";
            label2.Text = "Score: 0";
            timer1.Enabled = true;

            switch (difficulty)
            {
                case 1:
                    timer1.Interval = 1000;
                    pictureBox1.Width = pictureBox1.Height = 400;
                    label3.Text = "EASY";
                    label3.ForeColor = Color.Green;
                    break;
                case 2:
                    timer1.Interval = 750;
                    pictureBox1.Width = pictureBox1.Height = 300;
                    label3.Text = "NORMAL";
                    label3.ForeColor = Color.Orange;
                    break;
                case 3:
                    timer1.Interval = 500;
                    pictureBox1.Width = pictureBox1.Height = 250;
                    label3.Text = "HARD";
                    label3.ForeColor = Color.Red;
                    break;
                case 4:
                    timer1.Interval = 300;
                    pictureBox1.Width = pictureBox1.Height = 200;
                    label3.Text = "EXPERT";
                    label3.ForeColor = Color.DarkRed;
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            index = (short) random.Next(0, 6);
            pictureBox1.ImageLocation = Images[index];

            int x = random.Next(Width - pictureBox1.Width);
            int y = random.Next(Height - pictureBox1.Height);

            pictureBox1.Location = new Point(x, y);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            score += (index + 1);
            label2.Text = "Score: " + score.ToString();
        }

        private void EndGame()
        {
            new MainMenu().Show();
            Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            time--;
            if (time == 0) EndGame();
            label1.Text = "Time: " + time.ToString();
        }
    }
}
