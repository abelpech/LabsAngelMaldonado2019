using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;




namespace AngelMaldonado

{
    public partial class Page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

            Button1.Text = "SUMAR";
            RadioButton2.Checked = false;
            RadioButton3.Checked = false;
            RadioButton4.Checked = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int x, y;
            if (RadioButton1.Checked == true) {
                x = Convert.ToInt32(TextBox1.Text);
                y = Convert.ToInt32(TextBox2.Text);
                TextBox3.Text = Convert.ToString(Sumar(x, y));
                

            }
            else if (RadioButton2.Checked == true)
            {
                x = Convert.ToInt32(TextBox1.Text);
                y = Convert.ToInt32(TextBox2.Text);
                TextBox3.Text = Convert.ToString(restar(x, y));
            }
            else if (RadioButton3.Checked == true)
            {
                x = Convert.ToInt32(TextBox1.Text);
                y = Convert.ToInt32(TextBox2.Text);
                TextBox3.Text = Convert.ToString(multiplicar(x, y));
            }
            else if (RadioButton4.Checked == true)
            {
                x = Convert.ToInt32(TextBox1.Text);
                y = Convert.ToInt32(TextBox2.Text);
                TextBox3.Text = Convert.ToString(dividir(x, y));
            }
        }

        protected int Sumar( int x, int y)
        {
            return x + y;
        }
        protected int restar(int x, int y)
        {
            return x - y;
        }
        protected double multiplicar(int x, int y)
        {
            return x * y;
        }
        protected double dividir(int x, int y)
        {
            return x / y;
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Button1.Text = "RESTAR";
            RadioButton1.Checked = false;
            RadioButton3.Checked = false;
            RadioButton4.Checked = false;
        }

        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Button1.Text = "MULTIPLICAR";
            RadioButton1.Checked = false;
            RadioButton2.Checked = false;
            RadioButton4.Checked = false;
        }

        protected void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Button1.Text = "DIVIDIR";
            RadioButton1.Checked = false;
            RadioButton2.Checked = false;
            RadioButton3.Checked = false;

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            RadioButton1.Checked = false;
            RadioButton2.Checked = false;
            RadioButton3.Checked = false;
            RadioButton4.Checked = false;
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            Button1.Text = "OPERACION";
           
        }


    }
}