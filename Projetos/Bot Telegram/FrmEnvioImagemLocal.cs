using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BotTelegram1
{
    public partial class FrmEnvioImagemLocal : Form
    {
        public FrmEnvioImagemLocal()
        {
            InitializeComponent();
        }

        private void btnBsc_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                //Local padrão que sera aberto
                ofd.InitialDirectory = @"C:\Imagens";

                //Instrução de tipos de imagem
                ofd.Filter = "Imagens (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";

                //Só consegue selecionar 1 por vez
                ofd.Multiselect = false;

                //Verifica oque o usuario fez(clicou arquivo,fechou aba)
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    //Exibe Local da imagem,nome
                    txtLocalImagem.Text = ofd.FileName;
                }


            }
        }
    }
}
