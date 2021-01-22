using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//PASSANDO VALORES DO FORM FILHO PARA O PAI
namespace Compo
{
    public partial class Form1 : Form
    {
        public int num;
        public Form1()
        {
            InitializeComponent();
            num = 0;
        }

        private void b_add_Click(object sender, EventArgs e)
        {
            if (tb_esc.Text == "")//Testa se o campo esta vazio
            {
                MessageBox.Show("Digite Um Veiculo");//Exibe uma Mensagem
                tb_esc.Focus();//Foca na TextBox para digitar
            }
            else
            {
                tb_list.Text += tb_esc.Text + ","; //Acrescenta na Lista
            }
            tb_esc.Clear();//Limpa a TextBox
            tb_esc.Focus();//Foca na TextBox
            
        }

        private void b_limpa_Click(object sender, EventArgs e)
        {
            tb_list.Clear();//Limpa a Lista
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            F_veiculos f_Veiculos = new F_veiculos(tb_list.Text, this);//Instancia e passa a lista
            f_Veiculos.Show();//Abre a 2 Lista , SHOWDIALOG
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_valNum_Click(object sender, EventArgs e)
        {
            MessageBox.Show(num.ToString());
        }
    }
}
