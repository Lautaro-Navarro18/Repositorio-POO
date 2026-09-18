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
    Consigna: Solicitar usuario y contraseña mediante TextBox (usando UseSystemPasswordChar = true). Un CheckBox Acepto términos debe habilitar
    (Enabled = true) el Button Ingresar. Si la clave coincide con admin123, mostrar éxito en una Label; de lo contrario, mostrar advertencia. 
    */
    public partial class Form1 : Form
    {
        int ad = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == "admin123")
            {
                label1.Text = "GENIO, entre no mas";
            }
            else
            {
                ad++;
                label1.Text = "JA JA esa no era tenes " + ad + " advertencia";
                if(ad >= 100)
                {
                    button1.Enabled = false;
                    label1.Text = "Bueno ya veo que no sos un genio";
                }
            }
        }
    }
}
