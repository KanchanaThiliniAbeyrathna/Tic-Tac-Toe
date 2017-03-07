using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class StaticticsForm : Form
    {
        public StaticticsForm()
        {
            InitializeComponent();
        }

        private void ebutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public DataGridView getGridVeiw()
        {
            return dataGridView1;
        }

        private void StaticticsForm_Load(object sender, EventArgs e)
        {
            
        }

        private void ebutton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void b_button_Click(object sender, EventArgs e)
        {
            GameForm gf = new GameForm();
            gf.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}

