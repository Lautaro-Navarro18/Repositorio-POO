using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto2
{
    /*
    Consigna: Disponer un TextBox para el ingreso numérico y dos RadioButton: "Celsius a Fahrenheit" y "Fahrenheit a Celsius". 
    Al presionar un Button, realizar la fórmula correspondiente y mostrar el resultado en un Label. 
    */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double aux = double.Parse(textBox1.Text);
            if(radioButton1.Checked == true)
            {
                aux = (aux * 1.8) + 32;
            } else if(radioButton2.Checked == true)
            {
                aux = (aux - 32) / 1.8;
            }
            label1.Text = aux.ToString();
        }
    }
}
