using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Punto5
{
    /*
    Consigna: Cargar en un ComboBox tres opciones. Al cambiar la selección mediante el evento SelectedIndexChanged, 
    mostrar la imagen correspondiente dentro del PictureBox. 
    */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                pictureBox1.ImageLocation = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTia8OAO-yuBZHGXF6Fp8uv58R6DA55iL1vLtxB3ACvAA&s=10";
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                pictureBox1.ImageLocation = "https://www.diarioepoca.com/content/bucket/6/628376.jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                pictureBox1.ImageLocation = "https://i.ytimg.com/vi/_XlRbVNantc/maxresdefault.jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
