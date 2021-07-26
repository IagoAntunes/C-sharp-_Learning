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
        
        public int ndicas;
        //int[] repetido = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int vComputador;
        int vUsuario;

        public void Computador(){
            //PARTE 1
            //AQUI EU FAÇO O COMPUTADOR ESCOLHER UMA PALAVRA ALEATORIA;
            lb_t1.Text = "";
            string[] nomes = new string[7] { "Carro", "Cavalo", "Peixe", "Futebol", "Olimpiadas","Melancia","Avião" };
            string seila = "";
            int indice;

            Random sort = new Random();

            indice = sort.Next(nomes.Length);

            palavra = nomes[indice];
            palavra2 = palavra;

            lb_PC.Text = "R: " + palavra.ToString();

            //------------PARTE 2  ---------
            //PARA TAMPAR A PALAVRA COM ' ** '

            char[] teste = palavra2.ToCharArray();

            
            
            
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
            lb_t1.Text = seila.ToString();
            //lb_t2.Text = teste[1].ToString();
        }

        private void btn_Tentar_Click(object sender, EventArgs e){
            //PARTE 3
            //Objetivo de  pegar a palavra digitada pelo usuário e comprar com o computador
            string Tentativa;

            //Pegando palavra do TextBox
            Tentativa = txt_Try.Text;

            //Comparando com a palavra gerada pelo computador
            if (string.Equals(txt_Try.Text, palavra)) {
                MessageBox.Show("Palavras Iguais");
                vUsuario++;
                Computador();
            }
            else
            {
                MessageBox.Show("Palavras Diferentes");
                vComputador++;
            }

            lb_vRobo.Text = vComputador.ToString();
            lb_Vuser.Text = vUsuario.ToString();
            //lb_t2.Text = palavra.ToString();
        }

        private void txt_Try_TextChanged(object sender, EventArgs e)
        {

        }

        /*private void btn_Dica_Click(object sender, EventArgs e)
        {

            // int[] Idicas = new int[palavra2.Length];


            lb_user.Text = palavra2[0].ToString();

            seila = seila.Replace(seila[0],palavra2[0]);
                  repetido[0] = 1;
                 lb_t1.Text = seila.ToString();
            ndicas++;
           
            




        }*/
/*
 *         for (int i = ndicas; i < palavra2.Length; i++)
    {

        if (repetido[i] == 0 ) 
        {

            palavra2 = seila.Replace(seila[i],palavra2[i]);
            repetido[i] = 1;
            lb_t1.Text = palavra2.ToString();

        }*/

    }

}

