using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_vathomologoumeni_1
{
    public partial class DiceClicker : Form
    {
        //The array with the images, the difficulty, the random dice, score and time are all global variables, since we want them accessible in multiple functions.
        string[] Images = new string[6];
        short difficulty;
        short index = 0;
        int score = 0;
        int time = 60;

        public DiceClicker(short difficulty)
        {
            InitializeComponent();

            //We get the difficulty from the previous form with this constructor.
            this.difficulty = difficulty;
        }

        private void DiceClicker_Load(object sender, EventArgs e)
        {
            //Set the Image Locations as they're so we can pick a random image from the locations.
            Images[0] = "dice/dice1.png";
            Images[1] = "dice/dice2.png";
            Images[2] = "dice/dice3.png";
            Images[3] = "dice/dice4.png";
            Images[4] = "dice/dice5.png";
            Images[5] = "dice/dice6.png";

            //Set the labels and timers with their starting values.
            label1.Text = "Time: 60";
            label2.Text = "Score: 0";
            timer1.Enabled = timer2.Enabled = true;

            //The location movement speed and picturebox size depend on the difficulty the user chose.
            switch (difficulty)
            {
                case 1:
                    //The easiest difficulty has one second movement speed and 400x400 image size
                    timer1.Interval = 1000;
                    pictureBox1.Width = pictureBox1.Height = 400;
                    label3.Text = "EASY";
                    label3.ForeColor = Color.Green;
                    break;
                case 2:
                    //The normal difficulty has 0.75 seconds movement speed and 300x300 image size
                    timer1.Interval = 750;
                    pictureBox1.Width = pictureBox1.Height = 300;
                    label3.Text = "NORMAL";
                    label3.ForeColor = Color.Orange;
                    break;
                case 3:
                    //The hard difficulty has half a second movement speed and 250x250 image size
                    timer1.Interval = 500;
                    pictureBox1.Width = pictureBox1.Height = 250;
                    label3.Text = "HARD";
                    label3.ForeColor = Color.Red;
                    break;
                case 4:
                    //The easiest difficulty has 0.3 seconds movement speed and 200x200 image size
                    timer1.Interval = 300;
                    pictureBox1.Width = pictureBox1.Height = 200;
                    label3.Text = "EXPERT";
                    label3.ForeColor = Color.DarkRed;
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //This changes randomly the dice
            Random random = new Random();
            index = (short) random.Next(0, 6);
            pictureBox1.ImageLocation = Images[index];

            //The bomb only appears with a 5% chance and only if the difficulty is above Normal.
            if (difficulty > 2)
            {
                short bomb = (short) random.Next(0, 100);
                pictureBox1.ImageLocation = (bomb > 94) ? "dice/bomb.jpg" : pictureBox1.ImageLocation;
            }

            //the location also randomly changes. But we don't want it to clip out of the window. So we set the bounds accordingly
            int x = random.Next(Width - pictureBox1.Width);
            int y = random.Next(Height - pictureBox1.Height);

            pictureBox1.Location = new Point(x, y);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //When the player clicks the picture box, we add points to his score, depending on the dice
            if (pictureBox1.ImageLocation == "dice/bomb.jpg")
                score -= 10;
            else
                score += (index + 1);

            label2.Text = "Score: " + score.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //This timer controls the seconds left
            time--;
            if (time == 0)
                EndGame();

            label1.Text = "Time: " + time.ToString();
        }

        private void EndGame()
        {
            //When the timer runs out this function
            timer1.Enabled = timer2.Enabled = false;
            MessageBox.Show("Total Score: " + score.ToString(), "Game Over!");

            try
            {
                StreamWriter sw = new StreamWriter("highscores.txt", true);
                sw.WriteLine("George1|" + label3.Text + "|" + score.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot store score, file not found.\n Exception Message: " + ex.Message, "ERROR");
            }
                

            new MainMenu().Show();
            Close();
        }
    }
}
