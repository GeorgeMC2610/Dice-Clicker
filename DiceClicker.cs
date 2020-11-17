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
            
        }
    }
}
