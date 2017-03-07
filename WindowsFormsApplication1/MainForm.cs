using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OnePlayerButton_Click(object sender, EventArgs e)
        {
            OnePlayerForm f = new OnePlayerForm();
            f.Show();
            this.Hide();
        }

        private void TwoPlayerButton_Click(object sender, EventArgs e)
        {
            TwoPlayersForm f = new TwoPlayersForm();
            f.Show();
            this.Hide();
        }

        private void ebutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
