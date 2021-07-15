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
    }
}
