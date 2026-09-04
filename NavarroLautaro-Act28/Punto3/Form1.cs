using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto3
{
    /*
    Consigna: Armar una interfaz con un TextBox, un Button "Agregar", un Button "Eliminar" y un ListBox. 
    Permitir añadir el texto tipeado a la lista y borrar el elemento que el usuario seleccione. 
    */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Remove(textBox1.Text);
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            
        }
    }
}
