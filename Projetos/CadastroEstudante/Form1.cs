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

namespace RegistrarEstudante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load();
        }
        //Conectando Banco de dados
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-BQA4KG1\\SQLEXPRESS; Initial Catalog=gcbt;User Id=sa ; Password=123 ");
        SqlCommand cmd;
        SqlDataReader read;
        SqlDataAdapter drr;
        string id;
        bool Mode = true;
        string sql;


        public void Load()
        {
            try
            {
                //Pega todas os valores da tabela
                sql = "select * from Estudante";
                cmd = new SqlCommand(sql,con);
                con.Open();

                read = cmd.ExecuteReader();
                drr = new SqlDataAdapter(sql,con);
                dgvImagem.Rows.Clear();

                while (read.Read())
                {
                    dgvImagem.Rows.Add(read[0],read[1],read[2],read[3]);
                }
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void getId(string id)
        {
            sql = "select * from Estudante where id = '"+ id + "' ";


            cmd = new SqlCommand(sql,con);
            con.Open();
            read = cmd.ExecuteReader();

            while (read.Read())
            {
                txtName.Text = read[1].ToString();
                txtCurso.Text = read[2].ToString();
                txtHoras.Text = read[3].ToString();
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Guarda os valores inseridos no textBox
            string name = txtName.Text;
            string curso = txtCurso.Text;
            string horas = txtHoras.Text;

            if (Mode == true)
            {
                //Insere os valores no banco de dados
                sql = "insert into Estudante(Estudante,Curso,Horas) values(@Estudante,@Curso,@Horas)";
                con.Open();
                cmd = new SqlCommand(sql,con);
                cmd.Parameters.AddWithValue("@Estudante", name);
                cmd.Parameters.AddWithValue("@Curso", curso);
                cmd.Parameters.AddWithValue("@Horas", horas);
                MessageBox.Show("ADICIONOU SAPRORA");
                cmd.ExecuteNonQuery();

                //Limpa TextBox
                txtName.Clear();
                txtCurso.Clear();
                txtHoras.Clear();
                txtName.Focus();
            }
            else//MODO PARA EDIÇÃO
            {

                id = dgvImagem.CurrentRow.Cells[0].Value.ToString();

                //Editando valor
                sql = "update Estudante set Estudante = @Estudante, Curso= @Curso,Horas = @Horas where id = @id";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Estudante", name);
                cmd.Parameters.AddWithValue("@Curso", curso);
                cmd.Parameters.AddWithValue("@Horas", horas);
                cmd.Parameters.AddWithValue("@id", id);
                MessageBox.Show("Informações Adicionadas!!");
                cmd.ExecuteNonQuery();

                //Limpando TextBox
                txtName.Clear();
                txtCurso.Clear();
                txtHoras.Clear();
                txtName.Focus();


                button1.Text = "Salvar";
                Mode = true;
            }
            con.Close();
        }

        private void dgvImagem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Opção de Editar
            if (e.ColumnIndex == dgvImagem.Columns["Editar"].Index && e.RowIndex >= 0)
            {
                Mode = false;
                id = dgvImagem.CurrentRow.Cells[0].Value.ToString();
                getId(id);
                button1.Text = "Editar";
            }
            //Opção de Deletar
            else if (e.ColumnIndex == dgvImagem.Columns["Deletar"].Index && e.RowIndex >= 0)
            {
                //Deletando valor
                Mode = false;
                id = dgvImagem.CurrentRow.Cells[0].Value.ToString();
                sql = "delete from Estudante where id  = @id ";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id ", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleteeeee");
                con.Close();
            }
        }
        //Atualiza a tabela
        private void button3_Click(object sender, EventArgs e)
        {
            Load();
        }
        //Limpar valores do TextBox
        private void button2_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtCurso.Text = string.Empty;
            txtHoras.Text = string.Empty;
            txtName.Focus();
            button1.Text = "Salvar";
            Mode = true;
        }
    }
}
