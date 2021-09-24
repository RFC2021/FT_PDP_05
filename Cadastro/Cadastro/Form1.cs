using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Cadastro
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }
        private MySqlConnectionStringBuilder conexaoBanco()
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "cadastro";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            conexaoBD.SslMode = 0;
            return conexaoBD;
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            atualizarGrid();
        }

        private void atualizarGrid()
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM cliente WHERE ativocliente = 1 ";
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dgcadastro.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dgcadastro.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetInt32(0);//ID
                    row.Cells[1].Value = reader.GetString(1);//NOME
                    row.Cells[2].Value = reader.GetString(2);//ANO NASC
                    row.Cells[3].Value = reader.GetString(3);//PREFERÊNCIAS
                    row.Cells[4].Value = reader.GetString(4);//NÍVEL FIDELIDADE
                    dgcadastro.Rows.Add(row);//ADICIONO A LINHA NA TABELA

                }

                realizaConexacoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
                Console.WriteLine(ex.Message);
            }

        }

        private void btlimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void limparCampos()

        {
            tbId.Clear();
            tbNome.Clear();
            tbAno.Clear();
            tbPref.Clear();
            tbNivel.Clear();

        }

        private void btcadastrar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();

                comandoMySql.CommandText = "INSERT INTO cliente (nomeCliente,dataNasc,clientePref,nivelFid) " +
                    "VALUES( '" + tbNome.Text + "','" + Convert.ToInt16(tbAno.Text) + "', '" + tbPref.Text + "', '" + tbNivel.Text + "')";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close();
                MessageBox.Show("Inserido com sucesso");
                atualizarGrid();
                limparCampos();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btatualizar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand(); //Crio um comando SQL
                comandoMySql.CommandText = "UPDATE cliente SET nomeCliente = '" + tbNome.Text + "', " +
                    "dataNasc = '" + tbAno.Text + "', " +
                    "clientePref = '" + tbPref.Text + "' WHERE idCliente = " + tbId.Text + "";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close(); // Fecho a conexão com o banco
                MessageBox.Show("Atualizado com sucesso"); //Exibo mensagem de aviso
                atualizarGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Não foi possivel abrir a conexão! ");
                Console.WriteLine(ex.Message);
            }
        }

       





            private void dgcadastro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgcadastro.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgcadastro.CurrentRow.Selected = true;
                //preenche os textbox com as células da linha selecionad
                tbNome.Text = dgcadastro.Rows[e.RowIndex].Cells["colnome"].FormattedValue.ToString();
                tbAno.Text = dgcadastro.Rows[e.RowIndex].Cells["colAnonasc"].FormattedValue.ToString();
                tbPref.Text = dgcadastro.Rows[e.RowIndex].Cells["colpref"].FormattedValue.ToString();
                tbNivel.Text = dgcadastro.Rows[e.RowIndex].Cells["colniv"].FormattedValue.ToString();
                tbId.Text = dgcadastro.Rows[e.RowIndex].Cells["colid"].FormattedValue.ToString();
            }
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand(); //Crio um comando SQL
                // "DELETE FROM filme WHERE idFilme = "+ textBoxId.Text +""
                //comandoMySql.CommandText = "DELETE FROM filme WHERE idFilme = " + tbID.Text + "";
                comandoMySql.CommandText = "UPDATE cliente SET ativoCliente = 0 WHERE idCliente = " + tbId.Text + "";

                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close(); // Fecho a conexão com o banco
                MessageBox.Show("Deletado com sucesso"); //Exibo mensagem de aviso
                atualizarGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Não foi possivel abrir a conexão! ");
                Console.WriteLine(ex.Message);
            }

        }


    }


 }      
