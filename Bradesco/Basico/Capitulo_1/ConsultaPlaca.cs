using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void cbNumero_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 novo = new Form1();

            novo.Show();

            this.Visible = false;


        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            switch (cbNumero.Text)
            {

                case "1 ou 2":
                    lblRes.Text = "Segunda Feira";
                    break;
                case "3 ou 4":
                    lblRes.Text = "Terca Feira";
                    break;
                case "5 ou 6":
                    lblRes.Text = "Quarta Feira";
                    break;
                case "7 ou 8":
                    lblRes.Text = "Quinta Feira";
                    break;
                case "9 ou 0":
                    lblRes.Text = "Sexata Feira";
                    break;

            }
        }
    }
}
/* FORMS1 */
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

        private void cboSemana_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboSemana.Text) 
            {
                case "Domingo":
                    MessageBox.Show("Domingo");
                    break;

                case "Segunda":
                    MessageBox.Show("Segunda");
                    break;

                case "Terca":
                    MessageBox.Show("Terca");
                    break;

                case "Quarta":
                    MessageBox.Show("Quarta");
                    break;

                case "Quinta":
                    MessageBox.Show("Quinta");
                    break;

                case "Sexta":
                    MessageBox.Show("Sexta");
                    break;

                case "Sabado":
                    MessageBox.Show("Sabado");
                    break;





            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 novo = new Form2();

            novo.Show();

            this.Visible = false;
        }
    }
}
