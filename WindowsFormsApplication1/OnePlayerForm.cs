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
    public partial class OnePlayerForm : Form
    {
        public static string t;
        public OnePlayerForm()
        {
            InitializeComponent();
        }


        private void OnePlayerForm_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PlayerXtextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PlayerXtextBox_Click(object sender, EventArgs e)
        {
            
        }
        public static String getPlayerXValue()
        {
            return t;

        }

        private void ebutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Enter Player name here");
            }
            else
            {
                GameForm gf = new GameForm();
                GameForm.aiGame = true;
                gf.Show();
                this.Hide();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            t = textBox1.Text;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
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
