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
    public partial class F_filhoCheckBox : Form
    {
        public F_CheckBox f_cb;
        public F_filhoCheckBox()
        {
            InitializeComponent();
            try //(Application.OpenForms["F_CheckBox"].Created)
            {
                f_cb = Application.OpenForms["F_CheckBox"] as F_CheckBox;
                cb_carro.Checked = f_cb.cb_carro.Checked;
                cb_aviao.Checked = f_cb.cb_aviao.Checked;
                cb_navio.Checked = f_cb.cb_navio.Checked;
                cb_onibus.Checked = f_cb.cb_onibus.Checked;
                cb_patinete.Checked = f_cb.cb_patinete.Checked;
            }
            catch
            {
                MessageBox.Show("Erro ao abrir :(");
            }
        }

        private void cb_carro_CheckedChanged(object sender, EventArgs e)
        {
            f_cb.cb_carro.Checked = cb_carro.Checked;
        }

        private void cb_aviao_CheckedChanged(object sender, EventArgs e)
        {
            f_cb.cb_aviao.Checked = cb_aviao.Checked;
        }

        private void cb_navio_CheckedChanged(object sender, EventArgs e)
        {
            f_cb.cb_navio.Checked = cb_navio.Checked;
        }

        private void cb_onibus_CheckedChanged(object sender, EventArgs e)
        {
            f_cb.cb_onibus.Checked = cb_onibus.Checked;
        }

        private void cb_patinete_CheckedChanged(object sender, EventArgs e)
        {
            f_cb.cb_patinete.Checked = cb_patinete.Checked;
        }
    }
}
