using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Banco_de_Dados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // Monta o caminho até o arquivo do Banco de Dados
                string pasta = Application.StartupPath + @"\DB\DBTeste.mdb";

                // Monta a conexão com o Banco de Dados Access
                string strConexao = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + pasta;

                // Realiza a conexão com Banco de Dados
                OleDbConnection conexao = new OleDbConnection(strConexao);

                // Abrir a Conexão
                conexao.Open();

                // Montando a String do SQL para a tabela de Clientes
                String SQL;
                SQL = "Insert Into Clientes (CPF, Nome, Telefone) Values";
                SQL += "('" + textCPF.Text + "','" + textNome.Text + "','" + textTelefone.Text + "')";

                // Cria o comando do SQL na conexão aberta
                OleDbCommand comando = new OleDbCommand(SQL, conexao);

                // Método p/Executar o comando SQL que não retorna dados
                comando.ExecuteNonQuery();
                MessageBox.Show("Dados gravados com Sucesso");

                textCPF.Clear();
                textNome.Clear();
                textTelefone.Clear();

                // Fechar a Conexão
                conexao.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void botaoAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Monta o caminho até o arquivo do Banco de Dados
                string pasta = Application.StartupPath + @"\DB\DBTeste.mdb";

                // Monta a conexão com o Banco de Dados Access
                string strConexao = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + pasta;

                // Realiza a conexão com Banco de Dados
                OleDbConnection conexao = new OleDbConnection(strConexao);

                // Abrir a Conexão
                conexao.Open();

                OleDbCommand comando = new OleDbCommand();
                comando.Connection = conexao;

                string consulta = "UPDATE Clientes SET Nome = '" + textNome.Text +
                                             "', Telefone = '" + textTelefone.Text +
                                             "+'WHERE CPF = '" + textCPF.Text + "'";

                comando.CommandText = consulta;

                // Método para executar o comando SQL que não retorna dados
                comando.ExecuteNonQuery();
                MessageBox.Show("Dados atualizados com Sucesso");

                textCPF.Clear();
                textNome.Clear();
                textTelefone.Clear();

                // Fechar a Conexão
                conexao.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void botaoExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                // Monta o caminho até o arquivo do Banco de Dados
                string pasta = Application.StartupPath + @"\DB\DBTeste.mdb";

                // Monta a conexão com o Banco de Dados Access
                string strConexao = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + pasta;

                // Realiza a conexão com Banco de Dados
                OleDbConnection conexao = new OleDbConnection(strConexao);

                // Abrir a Conexão
                conexao.Open();

                OleDbCommand comando = new OleDbCommand();
                comando.Connection = conexao;

                string excluir = "DELETE FROM Clientes WHERE CPF = '" + textCPF.Text + "'";

                comando.CommandText = excluir;

                // Método para executar o comando SQL que não retorna dados
                comando.ExecuteNonQuery();
                MessageBox.Show("Dados excluidos com Sucesso");

                textCPF.Clear();
                textNome.Clear();
                textTelefone.Clear();

                // Fechar a Conexão
                conexao.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void botaoConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                // Monta o caminho até o arquivo do Banco de Dados
                string pasta = Application.StartupPath + @"\DB\DBTeste.mdb";

                // Monta a conexão com o Banco de Dados Access
                string strConexao = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + pasta;

                // Realiza a conexão com Banco de Dados
                OleDbConnection conexao = new OleDbConnection(strConexao);

                string procura = "SELECT * FROM Clientes";

                if (textCPF.Text != "")
                {
                    procura = "SELECT * FROM Clientes" + "WHERE CPF LIKE '" + textCPF + "'";
                }

                DataTable dados = new DataTable();

                OleDbDataAdapter adaptacao = new OleDbDataAdapter(procura, conexao);

                // Abrindo a conexão
                conexao.Open();
                adaptacao.Fill(dados);

                textCPF.Text = (string)dados.Rows[0][1];
                textNome.Text = (string)dados.Rows[0][2];
                textTelefone.Text = (string)dados.Rows[0][3];
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}