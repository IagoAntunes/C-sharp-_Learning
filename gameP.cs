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
            //PARTE 1
            //AQUI EU FAÇO O COMPUTADOR ESCOLHER UMA PALAVRA ALEATORIA;

            string[] nomes = new string[3] { "Mac", "Jessica", "MiMi" };

            int indice;

            Random sort = new Random();

            indice = sort.Next(nomes.Length);

            palavra = nomes[indice];
            palavra2 = palavra;

            lb_PC.Text = palavra.ToString();

            //------------PARTE 2  ---------
            //PARA TAMPAR A PALAVRA COM ' ** '

            char[] teste = palavra2.ToCharArray();

            string seila;
            seila = ".";
            
            //Colocando * para representar cada letra da palavra
            for (int i = 0; i < palavra2.Length; i++)
            {
                teste[i] = '*';
            }
            //Juntando os * 
            for (int i = 0; i < palavra2.Length; i++)
            {
                seila = seila + teste[i].ToString();
            }
            //Mostrando palavra censurada no LABEL
            lb_user.Text = seila.ToString();
        }

        private void btn_Tentar_Click(object sender, EventArgs e)
        {
            //PARTE 3
            //Objetivo de  pegar a palavra digitada pelo usuário e comprar com o computador
            string Tentativa;

            //Pegando palavra do TextBox
            Tentativa = txt_Try.ToString();

            //Comparando com a palavra gerada pelo computador
            if (string.Equals(txt_Try.ToString(), palavra)) {
                MessageBox.Show("Palavras Iguais");
            }
            else
            {
                MessageBox.Show("Palavras Diferentes");
            }

            //lb_t1.Text = Tentativa.ToString();
            //lb_t2.Text = palavra.ToString();
        }

        private void txt_Try_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
