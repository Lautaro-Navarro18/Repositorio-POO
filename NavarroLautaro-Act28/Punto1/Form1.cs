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
    Consigna: Crear un formulario con tres TextBox para ingresar notas y un Button Calcular. Convertir los valores con int.Parse() o double.Parse() y 
    mostrar en una Label el promedio. Si la nota es mayor o igual a 6, cambiar el color del texto de la etiqueta a verde; de lo contrario, a rojo. 
    */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double aux = double.Parse(textBox1.Text) + double.Parse(textBox2.Text) + double.Parse(textBox3.Text);
            aux /= 3;
            if(aux > 6)
            {
                label1.ForeColor = Color.LimeGreen;
            }
            else
            {
                label1.ForeColor = Color.Red;
            }
            label1.Text = aux.ToString();
        }
    }
}
