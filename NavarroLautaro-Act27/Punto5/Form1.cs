using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto5
{
    /*
    Actividad 5: Configuración de Suscripción
    Problema:
     Una aplicación ofrece distintos niveles de suscripción.
    Requisitos:
     ● Usar un ComboBox para elegir el tipo de plan: "Gratis", "Básico", "Premium".
     ● Incluir dos CheckBox para elegir servicios adicionales (por ejemplo: "Soporte técnico", "Acceso anticipado").
     ● Al presionar el botón "Guardar", se debe mostrar en un Label un resumen con el plan y los servicios elegidos. 
    */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Premium")
            {
                if (checkBox1.Checked == true)
                {
                    label1.Text = "Suscripcion: " + comboBox1.Text + " servicios adicionales " + checkBox1.Text;
                }
                if (checkBox2.Checked == true)
                {
                    label1.Text = "Suscripcion: " + comboBox1.Text + " servicios adicionales " + checkBox2.Text;
                }
            }
            else
            {
                label1.Text = "Suscripcion: " + comboBox1.Text + " Soporte tecnico regular";
            }
        }
    }
}
