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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panelLado.Height = btnHome.Height;
            panelLado.Top = btnHome.Top;
            userHome1.BringToFront();
        }

        private void btnCronometro_Click(object sender, EventArgs e)
        {
            panelLado.Height = btnCronometro.Height;
            panelLado.Top = btnCronometro.Top;
            userCronometro1.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelLado.Height = btnHome.Height;

            
            panelLado.Top = btnHome.Top;
            userHome1.BringToFront();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            panelLado.Height = btnTask.Height;
            panelLado.Top = btnTask.Top;
            userListBox1.BringToFront();
        }
    }
}
