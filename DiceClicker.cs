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
        short difficulty;

        public DiceClicker(short difficulty)
        {
            InitializeComponent();
            this.difficulty = difficulty;
        }

        private void DiceClicker_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            switch (difficulty)
            {
                case 1:
                    label3.Text = "EASY";
                    label3.ForeColor = Color.Green;
                    break;
                case 2:
                    label3.Text = "NORMAL";
                    label3.ForeColor = Color.Orange;
                    break;
                case 3:
                    label3.Text = "HARD";
                    label3.ForeColor = Color.Red;
                    break;
                case 4:
                    label3.Text = "IMPOSSIBLE";
                    label3.ForeColor = Color.DarkRed;
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string[] Images = new string[6];
            Images[0] = "dice/dice1.png";
            Images[1] = "dice/dice2.png";
            Images[2] = "dice/dice3.png";
            Images[3] = "dice/dice4.png";
            Images[4] = "dice/dice5.png";
            Images[5] = "dice/dice6.png";

            Random random = new Random();
            int index = random.Next(0, 6);
            pictureBox1.ImageLocation = Images[index];
        }
    }
}
