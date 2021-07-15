using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            decimal num1, num2, num3, resultado;

            num1 = Convert.ToDecimal(txt_Num1.Text);
            num2 = Convert.ToDecimal(txt_Num2.Text);
            num3 = Convert.ToDecimal(txt_Num3.Text);
            resultado = (num1 + num2 + num3)/3 ;
            txt_Media.Text = resultado.ToString();


        }
    }
}
