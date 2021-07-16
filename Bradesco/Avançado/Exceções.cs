using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            int num1, num2, resultado;

            try{
                num1 = int.Parse(textBox1.Text);
                num2 = int.Parse(textBox2.Text);
                resultado = num1 + num2;
                textBox3.Text = resultado.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Digite um NUMERO!");
            }
            finally{
                MessageBox.Show("Aperte OK para sair");
                Close();
            }

        }
    }
}
