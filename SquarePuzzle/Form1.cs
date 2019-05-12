using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquarePuzzle
{
    public partial class Puzzle : Form
    {
        public Puzzle()
        {
            InitializeComponent();
        }

        private void Puzzle_Load(object sender, EventArgs e)
        {

        }

        private void plybtn_Click(object sender, EventArgs e)
        {
            Game frm = new Game();
            frm.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void scorebtn_Click(object sender, EventArgs e)
        {
            Process.Start("D:\\enyüksekskor.txt");

        }
    }
}
