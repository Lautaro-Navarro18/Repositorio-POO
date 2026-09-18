using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto1
{
    /*
    Consigna: Disponer tres CheckBox con productos y precios fijos. Un Button Calcular Total debe evaluar los controles seleccionados 
    (Checked == true), sumar sus costos y mostrar el monto final en un Label. 
    */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int aux = 0;
            if (checkBox1.Checked == true)
            {
                aux += 2500;
            }
            if (checkBox2.Checked == true)
            {
                aux += 500;
            }
            if (checkBox3.Checked == true)
            {
                aux += 15000;
            }
            label1.Text = aux.ToString();
        }
    }
}
