using System;
using System.Windows.Forms;

namespace ConsultarCEPs
{
    public partial class FrmConsultarCEP : Form
    {
        public FrmConsultarCEP()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //Verifica se tem algo digitado no txtBox
            if (!string.IsNullOrWhiteSpace(txtCEP.Text.Trim()))
            {
                using(var ws = new BuscarCEP.WSCorreios.AtendeClienteClient())
                {
                    try
                    {
                        var endereco = ws.consultaCEP(txtCEP.Text.Trim());

                        txtEstado.Text = endereco.uf;
                        txtCidade.Text = endereco.cidade;
                        txtBairro.Text = endereco.bairro;
                        txtRua.Text = endereco.end;


                    }
                    //Caso aconteça algum erro
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            //Se nao tiver nada digitado informa erro
            else
            {
                MessageBox.Show("Você deve digitar um CEP valido!!",this.Text,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Limpa todos os TextBox
            txtCEP.Text = string.Empty;
            txtEstado.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtRua.Text = string.Empty;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Fecha a interface
            this.Close();
        }
    }
}
