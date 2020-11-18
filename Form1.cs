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
    public partial class MainMenu : Form
    {
        string[] EasyHI = new string[5];
        string[] NormalHI = new string[5];
        string[] HardHI = new string[5];
        string[] ExpertHI = new string[5];
        short option;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            playButton.Enabled = false;
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

        //In each of these functions the difficulty option changes depending on the radio buttons
        private void Easy_CheckedChanged(object sender, EventArgs e)
        {
            playButton.Enabled = true;
            option = (Easy.Checked) ? (short)1 : option; 
        }

        private void Normal_CheckedChanged(object sender, EventArgs e)
        {
            playButton.Enabled = true;
            option = (Normal.Checked) ? (short)2 : option;
        }

        private void Hard_CheckedChanged(object sender, EventArgs e)
        {
            playButton.Enabled = true;
            option = (Hard.Checked) ? (short)3 : option;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            playButton.Enabled = true;
            option = (Expert.Checked) ? (short)4 : option;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ExitGame_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Easy_HI_Click(object sender, EventArgs e)
        { 
            MessageBox.Show("1. " + EasyHI[0] + "\n" +
                            "2. " + EasyHI[1] + "\n" +
                            "3. " + EasyHI[2] + "\n" +
                            "4. " + EasyHI[3] + "\n" +
                            "5. " + EasyHI[4] + "\n", "Easy level highest score holders");
        }

        private void Normal_HI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. " + NormalHI[0] + "\n" +
                            "2. " + NormalHI[1] + "\n" +
                            "3. " + NormalHI[2] + "\n" +
                            "4. " + NormalHI[3] + "\n" +
                            "5. " + NormalHI[4] + "\n", "Normal level highest score holders");
        }

        private void Hard_HI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. " + HardHI[0] + "\n" +
                            "2. " + HardHI[1] + "\n" +
                            "3. " + HardHI[2] + "\n" +
                            "4. " + HardHI[3] + "\n" +
                            "5. " + HardHI[4] + "\n", "Hard level highest score holders");
        }

        private void Expert_HI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. " + ExpertHI[0] + "\n" +
                            "2. " + ExpertHI[1] + "\n" +
                            "3. " + ExpertHI[2] + "\n" +
                            "4. " + ExpertHI[3] + "\n" +
                            "5. " + ExpertHI[4] + "\n", "Expert level highest score holders");
        }
    }
}
