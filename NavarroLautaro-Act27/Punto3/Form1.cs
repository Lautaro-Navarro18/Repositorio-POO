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
    Actividad 3: Elección de Paquete de Viaje
    Problema:
     Una agencia de viajes ofrece distintos tipos de paquetes turísticos.
    Requisitos:
     ● Usar tres RadioButton para seleccionar el destino principal: "Playa", "Montaña" o "Ciudad".
     ● Agregar un ComboBox para elegir la duración del viaje (ejemplo: "3 días", "7 días", "15 días").
     ● Un botón "Confirmar" debe mostrar en un Label la opción seleccionada. 
    */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                label1.Text = "Destino: " + radioButton1.Text + " duracion " + comboBox1.Text;
            }
            if (radioButton2.Checked == true)
            {
                label1.Text = "Destino: " + radioButton2.Text + " duracion " + comboBox1.Text;
            }
            if (radioButton3.Checked == true)
            {
                label1.Text = "Destino: " + radioButton3.Text + " duracion " + comboBox1.Text;
            }
        }
    }
}
