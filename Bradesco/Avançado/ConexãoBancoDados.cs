using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
   
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.Cst;


            try
            {
                con.Open();
                con.Close();

                MessageBox.Show("A conexao foi realizada com sucesso");
            }
            catch(Exception ex)
            {
                MessageBox.Show(String.Format("Falha {0}",ex.Message));
            }




        }
    }
}
