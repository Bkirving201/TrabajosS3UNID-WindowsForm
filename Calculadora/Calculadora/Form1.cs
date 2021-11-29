using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        bool s = true;
        double operacion,resultado,igual;
        string tipo,borrado;

        public Form1()
        {
            InitializeComponent();
        }

        private void BIGUAL_Click(object sender, EventArgs e)
        {
            igual = double.Parse(txtcaja2.Text);

            if (tipo == "+")
            {
                resultado = operacion + igual;
                txtcaja1.Text = " = " + txtcaja1.Text + igual.ToString();
                txtcaja2.Text = resultado.ToString();
            }

            else if (tipo == "-")
            {
                resultado = operacion - igual;
                txtcaja1.Text = " = " + txtcaja1.Text + igual.ToString();
                txtcaja2.Text = resultado.ToString();
            }

            else if (tipo == "/")
            {
                resultado = operacion / igual;
                txtcaja1.Text = " = " + txtcaja1.Text + igual.ToString();
                txtcaja2.Text = resultado.ToString();
            }

            else if (tipo == "x")
            {
                resultado = operacion * igual;
                txtcaja1.Text = " = " + txtcaja1.Text + igual.ToString();
                txtcaja2.Text = resultado.ToString();
            }
        }

        private void B1_Click(object sender, EventArgs e)
        {
            if (s == true)
            {
                txtcaja2.Text = "1";
                s = false;
            }
            else
            {
                txtcaja2.Text = txtcaja2.Text + "1";
            }
        }

        private void B2_Click(object sender, EventArgs e)
        {
            if (s == true)
            {
                txtcaja2.Text = "2";
                s = false;
            }
            else
            {
                txtcaja2.Text = txtcaja2.Text + "2";
            }
        }

        private void B3_Click(object sender, EventArgs e)
        {
            if (s == true)
            {
                txtcaja2.Text = "3";
                s = false;
            }
            else
            {
                txtcaja2.Text = txtcaja2.Text + "3";
            }
        }

        private void B4_Click(object sender, EventArgs e)
        {
            if (s == true)
            {
                txtcaja2.Text = "4";
                s = false;
            }
            else
            {
                txtcaja2.Text = txtcaja2.Text + "4";
            }
        }

        private void B5_Click(object sender, EventArgs e)
        {
            if (s == true)
            {
                txtcaja2.Text = "5";
                s = false;
            }
            else
            {
                txtcaja2.Text = txtcaja2.Text + "5";
            }
        }

        private void B6_Click(object sender, EventArgs e)
        {
            if (s == true)
            {
                txtcaja2.Text = "6";
                s = false;
            }
            else
            {
                txtcaja2.Text = txtcaja2.Text + "6";
            }
        }

        private void B7_Click(object sender, EventArgs e)
        {
            if (s == true)
            {
                txtcaja2.Text = "7";
                s = false;
            }
            else
            {
                txtcaja2.Text = txtcaja2.Text + "7";
            }
        }

        private void B8_Click(object sender, EventArgs e)
        {
            if (s == true)
            {
                txtcaja2.Text = "8";
                s = false;
            }
            else
            {
                txtcaja2.Text = txtcaja2.Text + "8";
            }
        }

        private void B9_Click(object sender, EventArgs e)
        {
            if (s == true)
            {
                txtcaja2.Text = "9";
                s = false;
            }
            else
            {
                txtcaja2.Text = txtcaja2.Text + "9";
            }
        }

        private void B0_Click(object sender, EventArgs e)
        {
            if (txtcaja2.Text == "0")
            {
                txtcaja2.Text = "0";
            }
            else
            {
                txtcaja2.Text = txtcaja2.Text + "0";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Bsuma_Click(object sender, EventArgs e)
        {
            tipo = "+";
            operacion = double.Parse(txtcaja2.Text);
            txtcaja1.Text = txtcaja2.Text + " + ";
            s = true;
        }

        private void Bresta_Click(object sender, EventArgs e)
        {
            tipo = "-";
            operacion = double.Parse(txtcaja2.Text);
            txtcaja1.Text = txtcaja2.Text + " - ";
            s = true;
        }

        private void Bmulti_Click(object sender, EventArgs e)
        {
            tipo = "x";
            operacion = double.Parse(txtcaja2.Text);
            txtcaja1.Text = txtcaja2.Text + " x ";
            s = true;
        }

        private void Bporcent_Click(object sender, EventArgs e)
        {
            operacion = double.Parse(txtcaja2.Text);
            resultado = operacion / 100;
            txtcaja1.Text = txtcaja2.Text+" / 100";
            txtcaja2.Text = resultado.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtcaja1.Text = "";
            txtcaja2.Text = "0";
            s = true;
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            int contador = 0;
            borrado = txtcaja2.Text;
            contador = borrado.Length - 1;
            borrado = borrado.Substring(0, contador);
            txtcaja2.Text = borrado;

            if (txtcaja2.Text == " ")
            {
                txtcaja2.Text = "0";
                s = true;
            }
        }

        private void BDIV_Click(object sender, EventArgs e)
        {
            tipo = "/";
            operacion = double.Parse(txtcaja2.Text);
            txtcaja1.Text = txtcaja2.Text + " / ";
            s = true;
        }
    }
}
