using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Splash_Screen
{
    public partial class Form1 : Form
    {

        string[] produtos = new string[10];
        string[] codigo = new string[10];
        double[] valor = new double[10];
        double soma;




        public Form1()
        {
            InitializeComponent();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {


            if (txtCodigo.Text.Length == 3)
            {
                int indice = 0;
                for(int prod = 1; prod < codigo.Length; prod++)
                {
                    if (txtCodigo.Text == codigo[prod])
                    {
                        indice = prod;
                    }
                }
            if(indice == 0)
                {
                    MessageBox.Show("Produto nao encontrado");
                }
                else
                {
                    lstCaixa.Items.Add(txtCodigo.Text + "--" + produtos[indice] + "--R$" + valor[indice]);
                    soma = soma + valor[indice];
                    lblValor.Text = ("Valor Total R$" + soma);
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carregaArray();
            soma = 0;
        }

        private void carregaArray()
        {
            codigo[1] = "001";
            codigo[2] = "002";
            codigo[3] = "003";
            codigo[4] = "004";
            codigo[5] = "005";

            produtos[1] = "Pastel";
            produtos[2] = "Coxinha";
            produtos[3] = "Hot Dog";
            produtos[4] = "Chocolate";
            produtos[5] = "Suco";

            valor[1] = 6.00;
            valor[2] = 5.00;
            valor[3] = 12.00;
            valor[4] = 3.50;
            valor[5] = 8.00;

 


        }




    }
}
