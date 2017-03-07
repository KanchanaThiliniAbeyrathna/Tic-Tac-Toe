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
    public partial class TwoPlayersForm : Form
    {
        public static string tO;
        public static string tX;
        public TwoPlayersForm()
        {
            InitializeComponent();
        }

        private void label1_AutoSizeChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PlayerOlabel_Click(object sender, EventArgs e)
        {

        }


        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (PlayerXtextBox.Text.Equals("") || PlayerOtextBox.Text.Equals(""))
            {
                MessageBox.Show("Enter Player names here");
            }
            else {
                GameForm gf = new GameForm();
                GameForm.aiGame = false;
                gf.Show();
                this.Hide();
            }
            
        }

        private void PlayerXtextBox_TextChanged(object sender, EventArgs e)
        {
            tX = PlayerXtextBox.Text;
        }

        private void PlayerOtextBox_TextChanged(object sender, EventArgs e)
        {
            tO = PlayerOtextBox.Text;
        }

        public static String getPlayerXValue()
        {
            return tX;

        }

        public static String getPlayerOValue()
        {
            return tO;

        }

        private void ebutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void b_button_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }
    }
}
