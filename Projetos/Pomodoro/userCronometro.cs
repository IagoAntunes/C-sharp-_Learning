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
    public partial class UserCronometro : UserControl
    {
        int minutos=0;
        int segundos=0;
        int ClickMin,ClickSeg;


        public UserCronometro()
        {
            InitializeComponent();
        }

        private void btnIniCronometro_Click(object sender, EventArgs e)
        {
            if (minutos == 0 && segundos == 0)
            {
                MessageBox.Show("Adioce algum tempo!!");
            }
            else {
                if (ClickMin == 1 || ClickSeg == 1)
                {
                    if (btnIniCronometro.Text.Equals("Parar"))
                    {
                        timerCronometro.Enabled = false;
                        btnIniCronometro.Text = "Iniciar";
                    }
                    else
                    {
                        btnIniCronometro.Text = "Parar";
                        timerCronometro.Enabled = true;
                    }

                    lblTempo.Text = minutos + ":" + segundos;
                }
                else
                {
                    MessageBox.Show("Selecione uma Opcão(Minutos,Segundos)");
                }
                
            }
            
        }

        private void btnMinutosCrono_Click(object sender, EventArgs e)
        {
            ClickMin = 1;ClickSeg = 0;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (timerCronometro.Enabled == true)
            {
                MessageBox.Show("Timer em Andamento!");
            }
            else
            {
                if (ClickMin == 1)
                {
                    if (minutos <= 0)
                    {
                        MessageBox.Show("Limite!");
                    }
                    else
                    {
                        minutos--;
                        if (minutos < 10)
                        {
                            if (segundos < 10)
                            {
                                lblTempoCrono.Text = "0" + minutos + ":" + "0" + segundos;
                            }
                            else
                            {
                                lblTempoCrono.Text = "0" + minutos + ":" + "0" + segundos;
                            }

                        }
                        else
                        {
                            if (segundos < 10)
                            {
                                lblTempoCrono.Text = minutos + ":" + "0" + segundos;
                            }
                            else
                            {
                                lblTempoCrono.Text = minutos + ":" + "0" + segundos;
                            }
                        }
                    }
                }
                else if (ClickSeg == 1)
                {
                    if (segundos <= 1)
                    {
                        MessageBox.Show("Limite!");
                    }
                    else
                    {
                        segundos--;
                        if (segundos < 10)
                        {
                            if (minutos < 10)
                            {
                                lblTempoCrono.Text = "0" + minutos + ":" + "0" + segundos;
                            }
                            else
                            {
                                lblTempoCrono.Text = minutos + ":" + "0" + segundos;
                            }
                        }
                        else
                        {
                            if (minutos < 10)
                            {
                                lblTempoCrono.Text = "0" + minutos + ":" + segundos;
                            }
                            else
                            {
                                lblTempoCrono.Text = minutos + ":" + segundos;
                            }
                        }
                    }

                }
            }
        }
       

        private void timerCronometro_Tick(object sender, EventArgs e)
        {
            segundos--;
            if (minutos > 0)
            {
                if (segundos < 0)
                {
                    segundos = 59;
                    minutos--;
                }
            }
            if (minutos < 10 || segundos < 10)
            {
                if (segundos < 10)
                {
                    lblTempoCrono.Text = minutos + ":" + "0" + segundos;
                }
                else
                {
                    lblTempoCrono.Text = "0" + minutos + ":" + segundos;
                }
            }
            else
            {
                lblTempoCrono.Text = minutos + ":" + segundos;
            }


            if (minutos == 0 && segundos == 0)
            {
                timerCronometro.Enabled = false;

            }
        }

        private void btnAumentCrono_Click(object sender, EventArgs e)
        {
            if (timerCronometro.Enabled == true)
            {
                MessageBox.Show("Tempo em andamento!");
            }
            else
            {
                if (ClickMin == 1)
                {
                    if (minutos >= 59)
                    {
                        MessageBox.Show("Limite!");
                    }
                    else
                    {
                        minutos++;
                        if (minutos < 10)
                        {
                            if (segundos < 10)
                            {
                                lblTempoCrono.Text = "0" + minutos + ":" + "0" + segundos;
                            }
                            else
                            {
                                lblTempoCrono.Text = "0" + minutos + ":" + "0" + segundos;
                            }

                        }
                        else
                        {
                            if (segundos < 10)
                            {
                                lblTempoCrono.Text = minutos + ":" + "0" + segundos;
                            }
                            else
                            {
                                lblTempoCrono.Text = minutos + ":" + "0" + segundos;
                            }
                        }
                    }
                }
                else if (ClickSeg == 1)
                {
                    if (segundos >= 59)
                    {
                        MessageBox.Show("Limite!");
                    }
                    else
                    {
                        segundos++;
                        if (segundos < 10)
                        {
                            if (minutos < 10)
                            {
                                lblTempoCrono.Text = "0" + minutos + ":" + "0" + segundos;
                            }
                            else
                            {
                                lblTempoCrono.Text = minutos + ":" + "0" + segundos;
                            }
                        }
                        else
                        {
                            if (minutos < 10)
                            {
                                lblTempoCrono.Text = "0" + minutos + ":" + segundos;
                            }
                            else
                            {
                                lblTempoCrono.Text = minutos + ":" + segundos;
                            }
                        }
                    }

                }
            }
        }

        private void btnSegundosCrono_Click(object sender, EventArgs e)
        {
            ClickSeg = 1;ClickMin = 0;
        }
    }
}
