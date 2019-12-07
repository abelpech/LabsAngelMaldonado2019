using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasesForms2019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        static int operacion(int x, int y)
        {

            if (x > y)
                return x - y;
            else
                return x + y;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label5.Text = "Resultado: ";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int x, y;

            //Validacion para evitar EXCEPTION on CLEAR BUTTON

            if( textBox1.Text != "" && textBox2.Text != "")
            {
                x = Convert.ToInt32(this.textBox1.Text);

                y = Convert.ToInt32(this.textBox2.Text);

               // label5.Text = "Resultado: " + Convert.ToString(operacion(x, y));
            }
            
        }

        static int sumar(int x, int y)
        {

            return x + y;
        }

        static int restar(int x, int y) {
            return x - y;
        }

        static double multiplicar(double x, double y) {
            return x * y;
        }

        static double dividir(double x, double y) {
            return x / y;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int x, y; 
            x = Convert.ToInt32(this.textBox1.Text);

            y = Convert.ToInt32(this.textBox2.Text);

            label5.Text = "Resultado: " + Convert.ToString(sumar(x, y));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x, y;
            x = Convert.ToInt32(this.textBox1.Text);

            y = Convert.ToInt32(this.textBox2.Text);

            label5.Text = "Resultado: " + Convert.ToString(restar(x, y));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x, y;
            x = Convert.ToInt32(this.textBox1.Text);

            y = Convert.ToInt32(this.textBox2.Text);

            label5.Text = "Resultado: " + Convert.ToString(multiplicar(x, y));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int x, y;
            x = Convert.ToInt32(this.textBox1.Text);

            y = Convert.ToInt32(this.textBox2.Text);

            label5.Text = "Resultado: " + Convert.ToString(dividir(x, y));
        }
    }
}
