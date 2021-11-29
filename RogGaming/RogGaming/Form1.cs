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
    public partial class Form1 : Form
    {
        private object then;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void paneldegradado1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) {

            if (txtusser.Text == "Admin" && txtpass.Text == "1234") {
                Form Formulario2 = new Form2();
                Formulario2.Show();

                //Form Formulario1 = new Form1();
                //Formulario1.Hide();

                this.Hide();
            }

            else
            {
                 MessageBox.Show("Datos Invalidos");

            }
            
        
        
        }


           
     }
}

