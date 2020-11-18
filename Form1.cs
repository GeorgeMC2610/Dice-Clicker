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
    }
}
