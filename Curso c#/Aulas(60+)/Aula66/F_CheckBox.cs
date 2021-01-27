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
    public partial class F_CheckBox : Form
    {
        List<CheckBox> transp = new List<CheckBox>();


        public F_CheckBox()
        {
            InitializeComponent();
            transp.Add(cb_carro);
            transp.Add(cb_aviao);
            transp.Add(cb_navio);
            transp.Add(cb_onibus);
        }

        private void btn_transportesMarcados_Click(object sender, EventArgs e)
        {
            string txt = "";
            foreach (CheckBox t in transp)
            {
                if (t.Checked)
                {
                    txt += t.Text + ",";
                }
            }

            /*
             * if (cb_carro.Checked)
            {
                txt += cb_carro.Text + ", ";
            }
            if (cb_aviao.Checked)
            {
                txt += cb_aviao.Text + ", ";
            }
            if (cb_navio.Checked)
            {
                txt += cb_navio.Text + ", ";
            }
            if (cb_onibus.Checked)
            {
                txt += cb_onibus.Text + ", ";
            }
            */
            MessageBox.Show(txt);
        }

        private void cb_patinete_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_patinete.Checked)
            {
                MessageBox.Show("Patinete Marcado");
            }
        }
    }
}
