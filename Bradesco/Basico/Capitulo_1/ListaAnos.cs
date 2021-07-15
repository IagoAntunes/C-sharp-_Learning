/* FORM 1 */
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 novo = new Form2();

            novo.Show();

            this.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int contador;
            for(contador = 2016;contador >=1950; contador--)
            {
                cbAno.Items.Add(contador);

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 novo = new Form2();

            novo.Show();
            this.Visible = false;
        }
    }
}
/* FORMS 2 */
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

        private void Form2_Load(object sender, EventArgs e)
        {
            int contador;
            contador = 2016;

            while(contador >= 1950)
            {
                cbAno2.Items.Add(contador);
                contador--;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 novo = new Form1();

            novo.Show();
            this.Visible = false;
        }
    }
}
