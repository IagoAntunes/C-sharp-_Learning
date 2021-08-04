using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExportExcel
{
    public partial class FrmExportar : Form
    {
        public FrmExportar()
        {
            InitializeComponent();
        }
        private void FrmExportar_Load(object sender, EventArgs e)
        {
            //Exibe detalhes
            lvlContatos.View = View.Details;

            //Permite selecionar a linha toda
            lvlContatos.FullRowSelect = true;

            //Exibe as linhas no listview
            lvlContatos.GridLines = true;

            //Permite que o usuario edite o texto em uma celula
            lvlContatos.LabelEdit = true;

            //Adicionando colunas -> TEXTO - TAMANHO EM PIXEL - ALINHAMENTO
            lvlContatos.Columns.Add("Nome",300, HorizontalAlignment.Left);
            lvlContatos.Columns.Add("Celular", 150, HorizontalAlignment.Left);
            lvlContatos.Columns.Add("E-mail", 300, HorizontalAlignment.Left);

            //Comece escrevendo no txtNome
            txtNome.Select();


  

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnInserir_Click(object sender, EventArgs e)
        {
            //Verifica se o campo esta vazio
            if (txtNome.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Voce deve informar o Nome!! ", this.Text,MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else if (!txtCelular.MaskCompleted)
            {
                MessageBox.Show("Voce deve informar o Celular!! ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtEmail.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Voce deve informar o E-mail!! ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Definir os itens da lista
            ListViewItem lvi = new ListViewItem(txtNome.Text.Trim());
            lvi.SubItems.Add(txtCelular.Text.Trim());
            lvi.SubItems.Add(txtEmail.Text.Trim());

            //Adiciona o item criado 
            lvlContatos.Items.Add(lvi);
            clean();

        }

        public void clean()
        {
            txtNome.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtCelular.Text = string.Empty;
        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Limpando valores do textBox
            txtNome.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtCelular.Text = string.Empty;

            //Metodo para limpar valores do listvieww
            lvlContatos.Items.Clear();

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            //Cria uma aplicação Excel
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            //Habilita para ser utilizada
            app.Visible = true;

            //Adicionar pasta de trabalho
            Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Add(1);
            //Adicionar planilha
            Microsoft.Office.Interop.Excel.Worksheet ws =(Microsoft.Office.Interop.Excel.Worksheet) wb.Worksheets[1];

            //Começa a preencher a partir
            int linha = 2, coluna = 1;

            //Adicionando titulos
            ws.Cells[1, 1] = lvlContatos.Columns[0].Text;
            ws.Cells[1, 2] = lvlContatos.Columns[1].Text;
            ws.Cells[1, 3] = lvlContatos.Columns[2].Text;

            //Cada foreach percorre um elemento da listview
            foreach (ListViewItem lvi in lvlContatos.Items)
            {
                //Sempre começa na 1 coluna
                coluna = 1;
                foreach (ListViewItem.ListViewSubItem lvs in lvi.SubItems) 
                {
                    ws.Cells[linha,coluna] = lvs.Text;
                    //Anda uma coluna a direita
                    coluna++;

                }
                //Passa para a proxima linha
                linha++;
            }
        }
    }
}
