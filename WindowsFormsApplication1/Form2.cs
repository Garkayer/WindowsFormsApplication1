using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1 = int.Parse(txtConversor.Text);
            double n2 = 8.388608;
            double respuesta;
            respuesta = n1 * n2;
            lblRespuesta.Text += "Su Conversiòn de megabyte a bit es: " + respuesta;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double n1 = int.Parse(txtConversor.Text);
            double n2 = 1.048576;
            double respuesta;
            respuesta = n1 * n2;
            lblRespuesta.Text += "Su Conversiòn de megabyte a byte es: " + respuesta;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double n1 = int.Parse(txtConversor.Text);
            double n2 =1024;
            double respuesta;
            respuesta = n1 * n2;
            lblRespuesta.Text += "Su Conversiòn de megabyte a kilobyte es: " + respuesta;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double n1 = int.Parse(txtConversor.Text);
            double n2 = 0.0009765625;
            double respuesta;
            respuesta = n1 * n2;
            lblRespuesta.Text += "Su Conversiòn de megabyte a gigabyte es: " + respuesta;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double n1 = int.Parse(txtConversor.Text);
            double n2 = 0.00000095367431660625;
            double respuesta;
            respuesta = n1 * n2;
            lblRespuesta.Text += "Su Conversiòn de megabyte a terabyte es: " + respuesta;
        }
    }
}
