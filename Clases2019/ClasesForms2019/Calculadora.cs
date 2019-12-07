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
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnuno_Click(object sender, EventArgs e)
        {

            String desplegar;
            if (resultado.Text == null)
            resultado.Text = btnuno.Text;
            else
            {
                desplegar = resultado.Text;
            }


        }
    }
}
