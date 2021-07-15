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

        private void button2_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;
            num1 = Convert.ToDouble(txt_Num1.Text);
            num2 = Convert.ToDouble(txt_Num2.Text);
            resultado = num1 - num2;
            txt_Result.Text = resultado.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;
            num1 = Convert.ToDouble(txt_Num1.Text);
            num2 = Convert.ToDouble(txt_Num2.Text);
            resultado = num1 * num2;
            txt_Result.Text = resultado.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;
            num1 = Convert.ToDouble(txt_Num1.Text);
            num2 = Convert.ToDouble(txt_Num2.Text);
            resultado = num1 / num2;
            txt_Result.Text = resultado.ToString();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double num1, num2, resultado;
            num1 = Convert.ToDouble(txt_Num1.Text);
            num2 = Convert.ToDouble(txt_Num2.Text);
            resultado = (num1 + num2);
            txt_Result.Text = resultado.ToString();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_Num1.Text = "";
            txt_Num2.Text = "";
            txt_Result.Text = "";
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
