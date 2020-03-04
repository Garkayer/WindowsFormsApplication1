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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(txtConversor.Text);
            double n2 = 8.75;
            double respuesta;
            respuesta = n1 * n2;
            lblRespuesta.Text += "Su Conversiòn de dolar a colon es: " + respuesta;
          


        }

        private void button2_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(txtConversor.Text);
            double n2 = 111.27;
            double respuesta;
            respuesta = n1 * n2;
            lblRespuesta.Text += "Su Conversiòn de dolar a yen es: " + respuesta;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(txtConversor.Text);
            double n2 = 69.75;
            double respuesta;
            respuesta = n1 * n2;
            lblRespuesta.Text += "Su Conversiòn de dolar a rupia es: " + respuesta;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(txtConversor.Text);
            double n2 = 667.08;
            double respuesta;
            respuesta = n1 * n2;
            lblRespuesta.Text += "Su Conversiòn de dolar a peso chileno es: " + respuesta;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(txtConversor.Text);
            double n2 = 19.36;
            double respuesta;
            respuesta = n1 * n2;
            lblRespuesta.Text += "Su Conversiòn de dolar a peso mexicano es: " + respuesta;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(txtConversor.Text);
            double n2 = 39.69;
            double respuesta;
            respuesta = n1 * n2;
            lblRespuesta.Text += "Su Conversiòn de dolar a peso argentino es: " + respuesta;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(txtConversor.Text);
            double n2 = 0.00026;
            double respuesta;
            respuesta = n1 * n2;
            lblRespuesta.Text += "Su Conversiòn de dolar a bitcoin es: " + respuesta;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
