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
    Consigna: Crear un mini-juego donde un Button cuente cuántos clics realiza el usuario en 10 segundos. Al finalizar el tiempo 
    mediante el Timer, deshabilitar el botón (Enabled = false) y mostrar el puntaje acumulado en un MessageBox.Show.
    */
    public partial class Form1 : Form
    {
        int cont = 0;
        bool click = false;
        Timer myTimesito = new Timer();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!click)
            {
                myTimesito.Interval = 10 * 1000;
                myTimesito.Tick += new EventHandler(timer1_Tick);
                myTimesito.Start();
                click = true;
            }
            cont++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            myTimesito.Stop();
            MessageBox.Show("hola master ¿que onda? tuviste una cantidad asombrosa de " + cont + " clicks, felicidades");
            button1.Enabled = false;
        }
    }
}
