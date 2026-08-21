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
    2. Disponer 7 objetos de la clase Button con los días de la semana. Fijar en los atributos Text de cada botón los días de la semana. 
       Al presionar un botón mostrar en un objeto de la clase Label el día seleccionado. 
    */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = button7.Text;
        }
    }
}
