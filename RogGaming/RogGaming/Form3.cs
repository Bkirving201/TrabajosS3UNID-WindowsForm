using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RogGaming
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            PanelO.BackColor = Color.FromArgb(50, Color.DarkBlue);
            PanelO1.BackColor = Color.FromArgb(50, Color.DarkBlue);
            PanelO2.BackColor = Color.FromArgb(50, Color.DarkBlue);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
           PanelO.BackColor = Color.FromArgb(255, Color.Black);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void PanelO_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelO_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void PanelO1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form2 VentPrincipal = new Form2();
            VentPrincipal.Show();
        }
    }
}
