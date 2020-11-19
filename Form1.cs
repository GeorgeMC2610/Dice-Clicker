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
    public partial class MainMenu : Form
    {
        public static string[] EasyHI   = new string[5];
        public static string[] NormalHI = new string[5];
        public static string[] HardHI   = new string[5];
        public static string[] ExpertHI = new string[5];
        short option;
        bool radioButtonSelected = false, textBoxNotEmpty = false;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            playButton.Enabled = false;
            playButton.BackColor = Color.LightGray;

            for (int i = 0; i < 5; i++)
                EasyHI[i] = NormalHI[i] = HardHI[i] = ExpertHI[i] = "---";

            Player.SortHighScores();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            //when the player presses the play button, we hide this form, and we open the other one which plays the game
            DiceClicker form2 = new DiceClicker(option);        //We also pass the difficulty value in the other form
            form2.Show();

            //After we show the other form to the user, we hide this one, so it doesn't open twice.
            Hide();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkForEnable()
        {
            if (radioButtonSelected && textBoxNotEmpty)
            {
                playButton.Enabled = true;
                playButton.BackColor = Color.RoyalBlue;
            }
            else
            {
                playButton.Enabled = false;
                playButton.BackColor = Color.LightGray;
            }
        }

        //In each of these functions the difficulty option changes depending on the radio buttons
        private void Easy_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonSelected = true;
            option = 1;
        }

        private void Normal_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonSelected = true;
            option = 2;
        }

        private void Hard_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonSelected = true;
            option = 3;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonSelected = true;
            option = 4;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ExitGame_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Here we show the highest scores using the buttons provided
        private void ShowHighScores(string[] highScores, string level)
        {
            MessageBox.Show("1. " + highScores[0] + "\n" +
                            "2. " + highScores[1] + "\n" +
                            "3. " + highScores[2] + "\n" +
                            "4. " + highScores[3] + "\n" +
                            "5. " + highScores[4] + "\n", level + " level highest score holders");
        }

        private void Easy_HI_Click(object sender, EventArgs e)
        {
            ShowHighScores(EasyHI, "Easy");
        }

        private void Normal_HI_Click(object sender, EventArgs e)
        {
            ShowHighScores(NormalHI, "Normal");
        }

        private void Hard_HI_Click(object sender, EventArgs e)
        {
            ShowHighScores(HardHI, "Hard");
        }

        private void Expert_HI_Click(object sender, EventArgs e)
        {
            ShowHighScores(ExpertHI, "Expert");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
                textBoxNotEmpty = false;
            else
                textBoxNotEmpty = true;

            checkForEnable();
        }
    }
}
