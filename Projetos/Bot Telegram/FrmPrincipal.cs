using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotTelegram1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
        foreach (Control controle in this.Controls){
                if(controle is MdiClient)
                {
                    controle.BackgroundImage = Properties.Resources.telegram;
                    break;
                }


            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mensagensSimplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmEnvioTexto();
            frm.MdiParent = this;
            frm.Show();        
        }

        private void imagemWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmEnvioImagemWeb();
            frm.MdiParent = this;
            frm.Show();
        }

        private void imagemLocalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmEnvioImagemLocal();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}




