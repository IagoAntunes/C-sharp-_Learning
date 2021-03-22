using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compo
{
    public partial class F_ListView : Form
    {
        public F_ListView()
        {
            InitializeComponent();
        }

        private void limpar()
        {
            tb_id.Clear();
            tb_produto.Clear();
            tb_qtde.Clear();
            tb_preco.Clear();
        }


        private void btn_obter_Click(object sender, EventArgs e)
        {
            tb_id.Text = lv_produtos.SelectedItems[0].SubItems[0].Text;
            tb_produto.Text = lv_produtos.SelectedItems[0].SubItems[1].Text;
            tb_qtde.Text = lv_produtos.SelectedItems[0].SubItems[2].Text;
            tb_preco.Text = lv_produtos.SelectedItems[0].SubItems[3].Text;


        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            if(lv_produtos.SelectedIndices[0] == null)
            {
                MessageBox.Show("Selecione um Item para Remover");
            }
            else
            {
                lv_produtos.Items.RemoveAt(lv_produtos.SelectedIndices[0]);
            }   
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {

            if (tb_id.Text == "")
            {
                MessageBox.Show("ID vazio");
                tb_id.Focus();
                return;
            }
            if (tb_produto.Text == "")
            {
                tb_produto.Text = "NULL";
                tb_produto.Focus();
                return;
            }
            if (tb_qtde.Text == "")
            {
                tb_qtde.Text = "NULL";
                tb_qtde.Focus();
                return;
            }
            if (tb_preco.Text == "")
            {
                tb_preco.Text = "NULL";
                tb_preco.Focus();
                return;
            }


            String[] pr = new string[4];
            pr[0] = tb_id.Text;
            pr[1] = tb_produto.Text;
            pr[2] = tb_qtde.Text;
            pr[3] = tb_preco.Text;

            ListViewItem l = new ListViewItem(pr);
            lv_produtos.Items.Add(l);
            limpar();
        }
    }
}
