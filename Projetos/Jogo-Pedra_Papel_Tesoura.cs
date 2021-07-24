using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pedra_Papel_Tesoura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int PC;
        int usuario;
                public void computador()
        {
            int indice;
            int[] vetor2 = new int[3];

            Random r = new Random();
       
            vetor2[0] = 1;
            vetor2[1] = 2;
            vetor2[2] = 3;

            indice = r.Next(vetor2.Length);

            PC = vetor2[indice];

            if(PC == 1)
            {
                lb_PC.Text = "PEDRA";
            }else if(PC == 2)
            {
                lb_PC.Text = "PAPEL";
            }else if(PC == 3)
            {
                lb_PC.Text = "TESOURA";
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            usuario = 1;
            lb_User.Text = "PEDRA";


        }
        private void btn_Papel_Click(object sender, EventArgs e)
        {
            usuario = 2;
            lb_User.Text = "PAPEL";
        }

        private void btn_Tesoura_Click(object sender, EventArgs e)
        {
            usuario = 3;
            lb_User.Text = "TESOURA";
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            computador();
    
            //[1]PEDRA [2]PAPEL [3]TESOURA
            if(usuario == 1 && PC == 1){
                MessageBox.Show("EMPATE");
            }else if(usuario == 1 && PC == 2){
                MessageBox.Show("PC GANHOU");
            }else if(usuario == 1 && PC == 3){
                MessageBox.Show("USUARIO GANHOU");
            }
            if(usuario == 2 && PC == 1){
                MessageBox.Show("USUARIO GANHOU");
            }else if(usuario == 2 && PC == 2){
                MessageBox.Show("EMPATE");
            }else if(usuario == 2 && PC == 3){
                MessageBox.Show("PC GANHOU");
            }
            if(usuario == 3 && PC == 1){
                MessageBox.Show("PC GANHOU");
            }else if(usuario == 3 && PC == 2){
                MessageBox.Show("USUARIO GANHOU");
            }else if(usuario == 3 && PC == 3){
                MessageBox.Show("EMPATE");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(168, 192, 206);
        }
    }
}
