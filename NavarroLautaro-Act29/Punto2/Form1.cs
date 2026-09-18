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
    Consigna: Crear tres NumericUpDown restringidos entre 0 y 255 (Rojo, Verde, Azul). 
    Un Button cambiará la propiedad BackColor del Form aplicando Color.FromArgb(). 
    */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            string aux = numericUpDown1.Value.ToString();
            string aux1 = numericUpDown2.Value.ToString();          (no sabia que se podia hacer (int)numeric..... )
            string aux2 = numericUpDown3.Value.ToString();
            BackColor = Color.FromArgb(int.Parse(aux), int.Parse(aux1), int.Parse(aux2));
            */
            BackColor = Color.FromArgb((int)numericUpDown1.Value, (int)numericUpDown2.Value, (int)numericUpDown3.Value);
        }
    }
}
