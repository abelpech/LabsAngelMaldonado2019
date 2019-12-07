using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErrorProvider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            

            if (txt1.Text == "" && txt2.Text == "")
            {
                errorProvider1.SetError(txt1, "Uno de los valores no puede estar vacio1");
                errorProvider2.SetError(txt2, "Uno de los valores no puede estar vacio 2");
            }

            else
            {

                double num1 = Convert.ToInt32(txt1.Text);
                double num2 = Convert.ToInt32(txt2.Text);

                 if (num1 >= 5 && num2 >= 7)
                {
                    errorProvider3.SetError(txt1, "Exitoso");
                    errorProvider4.SetError(txt2, "Exitoso");




                    double num3 = num1 / num2;



                    //MessageBox.Show("El resultado es este" + num3);

                    MessageBox.Show("El resultado es este" + num3,
    "Critical Warning",
    MessageBoxButtons.OKCancel,
    MessageBoxIcon.Warning,
    MessageBoxDefaultButton.Button1,
    MessageBoxOptions.RightAlign,
    true);

                }


                //else if(num1 <10 )
                //{
                //    errorProvider1.SetError(txt1, "Ingrede un numero mayor o igual a 10");


                //}


                //else if (num1 >= 10 && num2 < 20 )
                //{

                //    errorProvider3.SetError(txt1, "Exitoso");
                //    errorProvider2.SetError(txt2, "Es menor a 20");

                //}


                //else if (num2 >= 20 && num1 <10)
                //{

                //    errorProvider3.SetError(txt2, "Exitoso");
                //    errorProvider2.SetError(txt1, "Es menor a 10");

                //}

                //else if (num2 < 20 && num1 < 10)
                //{

                //    errorProvider1.SetError(txt2, "Es menor a 20");
                //    errorProvider2.SetError(txt1, "Es menor a 10");

                //}









            }
            // -------------------------------------------------------



           

            //double num1 = Convert.ToInt32(txt1.Text);
            //double num2 = Convert.ToInt32(txt2.Text);
            

            //double num3 = num1 / num2;

            //MessageBox.Show("El resultado es este" + num3);


        }

        private void Btnlimpiar_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txt2.Clear();
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            errorProvider4.Clear();
        }

        private void Txt1_TextChanged(object sender, EventArgs e)
        {

            if ( txt1.Text != "") {


                double num1 = Convert.ToInt32(txt1.Text);
                if (num1 < 5)
                {

                    
                    errorProvider2.SetError(txt1, "Es menor a 5");

                }

                else
                {
                    errorProvider3.SetError(txt1, "Exitoso");

                }

            }

            else
            {
                errorProvider1.Clear();
                errorProvider2.Clear();
                errorProvider3.Clear();
                errorProvider4.Clear();

            }
        }

        private void Txt2_TextChanged(object sender, EventArgs e)
        {
            if (txt2.Text != "")
            {


                double num1 = Convert.ToInt32(txt2.Text);
                if (num1 < 7)
                {

                    errorProvider2.SetError(txt2, "Es menor a 7");

                }

                else
                {
                    errorProvider3.SetError(txt2, "Exitoso");

                }

            }

            else
            {
                errorProvider1.Clear();
                errorProvider2.Clear();
                errorProvider3.Clear();
                errorProvider4.Clear();

            }
        }
    }
}
