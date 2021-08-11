using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDinossauro
{

    public partial class Form1 : Form
    {

        //Velocidade dos obstaculos
        int Velocidade = 10;
        //Posição
        int pulo = 115;


        public Form1()
        {
            InitializeComponent();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && pulo > 55 && pulo < 175)
            {
                pulo = pulo - 60;
            }
            if(e.KeyCode == Keys.A)
            {
                dinossauro.Left += 30;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            pulo = pulo + 60;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dinossauro.Top = pulo;
            cacto2.Left -= Velocidade;
            cacto1.Left -= Velocidade;
            //Dinossauro no 100
            if(cacto1.Left <= -20)
            {
                cacto1.Left = 850;
            }
            if(cacto2.Left <= -20)
            {
                cacto2.Left = 850;
            }

            if (dinossauro.Bounds.IntersectsWith(cacto1.Bounds) || 
                dinossauro.Bounds.IntersectsWith(cacto2.Bounds)) 
            {
                fim();
            }
        }


        private void fim()
        {
            timer1.Stop();
            MessageBox.Show("GAME OVER");
        }
    }
}
