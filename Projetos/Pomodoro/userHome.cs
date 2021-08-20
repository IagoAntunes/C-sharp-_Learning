using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrincipalPomodoro
{
    public partial class UserHome : UserControl
    {
        int minuto;
        int segundo;
        int pomo, curt, longo;

 
        public UserHome()
        {
            InitializeComponent();
        }

        private void btnPomodoro_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                MessageBox.Show("Há um timer em andamento!!");
            }
            else
            {
                //Normal
                lblTempo.Text = 25 + ":" + "0" + "0";
                pomo = 1;
                curt = 0;
                pomo = 0;
                segundo = 00;
                minuto = 25;
                this.BackColor = Color.FromArgb(219, 82, 77);
                panelBack.BackColor = Color.FromArgb(223, 100, 95);
                //panel1.BackColor = Color.FromArgb(219, 82, 77);
                btnStart.ForeColor = Color.FromArgb(219, 82, 77);
            }
        }

        private void btnLong_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                MessageBox.Show("Um timer já esta em andamento!!");
            }
            else
            {
                //Long
                longo = 1;
                curt = 0;
                pomo = 0;
                segundo = 00;
                minuto = 15;

                lblTempo.Text = minuto + ":" + "00";

                this.BackColor = Color.FromArgb(67, 126, 168);
                panelBack.BackColor = Color.FromArgb(86, 139, 177);
                //panel1.BackColor = Color.FromArgb(86, 139, 177);
                btnStart.ForeColor = Color.FromArgb(67, 126, 168);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundo--;
            if (minuto > 0)
            {
                if (segundo < 0)
                {
                    segundo = 59;
                    minuto--;
                }
            }
            if (minuto < 10 || segundo < 10)
            {
                if (segundo < 10)
                {
                    lblTempo.Text = minuto + ":" + "0" + segundo;
                }
                else
                {
                    lblTempo.Text = "0" + minuto + ":" + segundo;
                }
            }
            else
            {
                lblTempo.Text = minuto + ":" + segundo;
            }


            if (minuto == 0 && segundo == 0)
            {
                timer1.Enabled = false;

            }
        }

        private void btnPomodoro_MouseDown(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.FromArgb(184, 74, 70);
        }

        private void btnShort_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                MessageBox.Show("Um timer já esta em andamento!!");
            }
            else
            {
                curt = 1;
                pomo = 0;
                longo = 0;
                //Short
                segundo = 00;
                minuto = 05;

                lblTempo.Text = "0" + minuto + ":" + "00";

                this.BackColor = Color.FromArgb(70, 142, 145);
                panelBack.BackColor = Color.FromArgb(89, 154, 156);
                //panel1.BackColor = Color.FromArgb(89, 154, 156);
                btnStart.ForeColor = Color.FromArgb(70, 142, 145);
            }
        }



        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text.Equals("Parar"))
            {
                timer1.Enabled = false;
                btnStart.Text = "Iniciar";
            }
            else
            {
                btnStart.Text = "Parar";
                timer1.Enabled = true;
            }
            //tempo = 3;
            //segundo = 0;
            //minuto = 3;
            lblTempo.Text = minuto + ":" + segundo;
        }
    }
}
