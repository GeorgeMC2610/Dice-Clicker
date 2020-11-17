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
            //DiceClicker form2 = new DiceClicker();
            //form2.Show();
            Hide();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Easy_CheckedChanged(object sender, EventArgs e)
        {
            playButton.Enabled = true;
            option = (Easy.Checked) ? (short) 1 : option; 
        }
    }
}
