using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngryBirds
{
    public partial class Form1 : Form
    {
        //Velocidade dos obstaculos
        int pipespeed = 5;
        //Posição
        int gravity = 15;
        int score = 0;

    
        public Form1()
        {
            InitializeComponent();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            //Muda a posição do passaro
            flappyBird.Top += gravity;
            //Musa a posição do obstaculo de baixo
            pipeBottom.Left -= pipespeed;
            //Muda a posição do obstaculo de cima
            pipeTop.Left -= pipespeed;

            ScoreText.Text = "Score: " + score;

            //Se o obstaculo sair da tela, reajusta para aparecer novamente
            if (pipeBottom.Left < -130)
            {
                pipeBottom.Left = 600;
                score++;
            }
            if(pipeTop.Left < -180)
            {
                pipeTop.Left = 600;
                score++;
            }
            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds)|| 
                flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds) ||
                flappyBird.Top < -25)
            {
                endgame();
            }

            if (score > 5)
            {
                pipespeed = 8;
            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            //Se nao estiver pressionando espaço sua posição é alterada para baixo
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            //Se estiver pressionando espaço a posição é alterada para cima
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }
        private void endgame()
        {
            gameTimer.Stop();
            ScoreText.Text += "Game Over!!!";

            var menu = new Iniciar();

            this.Close();
            menu.Show();
        }
    }
}
