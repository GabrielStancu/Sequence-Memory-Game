using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SequenceMemoryGame
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btNewGame_Click(object sender, EventArgs e)
        {
            Game f2 = new Game();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }

        private void btInstructions_Click(object sender, EventArgs e)
        {
            Instructions f2 = new Instructions();
            f2.ShowDialog();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
