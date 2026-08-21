using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto4
{
    /*
    4. Elaborar una interfaz gráfica que muestre una calculadora (utilizar objetos de la clase Button y un objeto de la clase Label donde se muestra el valor ingresado), 
       tener en cuenta que solo se debe implementar la interfaz y la carga de un valor de hasta 12 dígitos. 
    */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!(label1.Text.Length >= 12))
            {
                label1.Text += button1.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!(label1.Text.Length >= 12))
            {
                label1.Text += button2.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!(label1.Text.Length >= 12))
            {
                label1.Text += button3.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!(label1.Text.Length >= 12))
            {
                label1.Text += button4.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!(label1.Text.Length >= 12))
            {
                label1.Text += button5.Text;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!(label1.Text.Length >= 12))
            {
                label1.Text += button6.Text;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!(label1.Text.Length >= 12))
            {
                label1.Text += button7.Text;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!(label1.Text.Length >= 12))
            {
                label1.Text += button8.Text;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!(label1.Text.Length >= 12))
            {
                label1.Text += button9.Text;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!(label1.Text.Length >= 12))
            {
                label1.Text += button11.Text;
            }
        }
    }
}
