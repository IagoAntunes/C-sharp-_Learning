using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Computador();
        }
        public string palavra;
        public string palavra2;

        public void Computador()
        {
            //AQUI EU FAÇO O COMPUTADOR ESCOLHER UMA PALAVRA ALEATORIA;
            string[] nomes = new string[3] { "Mac", "Jessica", "MiMi" };


            int indice;

            Random sort = new Random();

            indice = sort.Next(nomes.Length);

            palavra = nomes[indice];
            palavra2 = palavra;

            lb_PC.Text = palavra.ToString();

            //--------------------------

            char[] teste = palavra2.ToCharArray();

            string seila;
            seila = ".";
            for (int i = 0; i < palavra2.Length; i++)
            {
                teste[i] = '*';
            }
            for (int i = 0; i < palavra2.Length; i++)
            {
                seila = seila + teste[i].ToString();
            }
            lb_user.Text = seila.ToString();
        }

        private void btn_Tentar_Click(object sender, EventArgs e)
        {
            string Tentativa;

            Tentativa = txt_Try.ToString();

            if (string.Equals(txt_Try.ToString(), palavra)) {
                MessageBox.Show("Palavras Iguais");
            }
            else
            {
                MessageBox.Show("Palavras Diferentes");
            }

            lb_t1.Text = Tentativa.ToString();
            //lb_t2.Text = palavra.ToString();
        }

        private void txt_Try_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
