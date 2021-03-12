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
    public partial class F_CheckedListBox : Form
    {
        public F_CheckedListBox()
        {
            InitializeComponent();
        }

        private void btn_motrarSelecionados_Click(object sender, EventArgs e)
        {
            string txt = "";
            int count=0;

            foreach(string t in clb_transportes.CheckedItems)
            {
                count++;
                
                txt += t + " ,";
                
            }



            if (count >= 1){
                txt = txt.Remove(txt.Length - 1, 1);
            }
            
            //txt = clb_transportes.CheckedItems[0].ToString();

            if(count >= 1)
            {
                MessageBox.Show("Numero de Veiculos" + count + "\n" + txt);
            }
            else
            {
                MessageBox.Show("Marque Algum Veiculo");
            }
           

        }

        private void btn_limparLista_Click(object sender, EventArgs e)
        {
                clb_transportes.Items.Clear();//Limpando

        }

        private void btn_resetarLista_Click(object sender, EventArgs e)
        {
            List<string> tr = new List<string>();
            tr.Add("Carro");
            tr.Add("Aviao");
            tr.Add("Navio");
            tr.Add("Onibus");
            tr.Add("Trem");

            clb_transportes.Items.AddRange(tr.ToArray());
        }

        private void btn_addNovoTransporte_Click(object sender, EventArgs e)
        {
            if(tb_NovoTransporte.Text != "")
            {
                clb_transportes.Items.Add(tb_NovoTransporte.Text);
                tb_NovoTransporte.Clear();
                tb_NovoTransporte.Focus();
            }
            
        }
    }
}