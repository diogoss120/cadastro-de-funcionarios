using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AgendaTelefonica
{
    public partial class Form1 : Form
    {
        int controleID = 0;
        void InsersaoDeDados(string msg, string alerta)
        {
            SqlConnection conexao = new SqlConnection("Data Source=COROLA;Initial Catalog=dbAgenda;Integrated Security=True");
            try
            {
                SqlCommand comando = new SqlCommand(msg, conexao);
                comando.Parameters.AddWithValue("@nome", txtPessoa.Text);
                comando.Parameters.AddWithValue("@ddd", txtdddPessoa.Text);
                comando.Parameters.AddWithValue("@contato", txtNumero.Text);
                comando.Parameters.AddWithValue("@cpf", txtCpf.Text);
                comando.Parameters.AddWithValue("@salario", txtSalario.Text);
                comando.Parameters.AddWithValue("@departamento", txtDepartamento.Text);
                comando.Parameters.AddWithValue("@numCasa", numCasa.Text);
                comando.Parameters.AddWithValue("@rua", txtRua.Text);
                comando.Parameters.AddWithValue("@bairro", txtBairro.Text);
                comando.Parameters.AddWithValue("@cidade", txtCidade.Text);
                comando.Parameters.AddWithValue("@id", controleID);
                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show(alerta);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexao.Close();
            }
        }
        void ConsultarDados()
        {
            string consulta = "";
            try
            {
                if(opcaoCpfOuNome.Text == "Nome")
                    consulta = "select nome, ddd, celular, cpf, salario, departamento, numCasa, rua, bairro, cidade, id from empregado where nome = @pesquisa";
                else
                    consulta = "select nome, ddd, celular, cpf, salario, departamento, numCasa, rua, bairro, cidade, id from empregado where cpf = @pesquisa";


                SqlConnection conexao = new SqlConnection("Data Source=COROLA;Initial Catalog=dbAgenda;Integrated Security=True");
                SqlCommand comando = new SqlCommand(consulta, conexao);
                comando.Parameters.AddWithValue("@pesquisa", pesquisaNome.Text);
                conexao.Open();
                SqlDataReader lista = comando.ExecuteReader();
                if (lista.Read())
                {   //ListaDeDados.Text = "Nome: "+ lista.GetString(0) +", Cpf:"+ lista.GetString(1) + "Cidade: "+lista.GetString(2);
                    txtPessoa.Text = lista.GetString(0);
                    txtdddPessoa.Text = lista.GetString(1);
                    txtNumero.Text = lista.GetString(2);
                    txtCpf.Text = lista.GetString(3);
                    txtSalario.Text = lista.GetSqlMoney(4).ToString();
                    txtDepartamento.Text = lista.GetString(5);
                    numCasa.Text = lista.GetSqlInt32(6).ToString();
                    txtRua.Text = lista.GetString(7);
                    txtBairro.Text = lista.GetString(8);
                    txtCidade.Text = lista.GetString(9);
                    controleID = (int)lista.GetSqlInt32(10); //para achar o Id do empregado
                }
                else
                {
                    MessageBox.Show("O nome especificado não foi localizado");
                }

                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void LimparOpcoes()
        {
            txtPessoa.Text = "";
            txtdddPessoa.Text = "";
            txtNumero.Text = "";
            txtCpf.Text = "";
            txtSalario.Text = "";
            txtDepartamento.Text = "";
            numCasa.Text = "";
            txtRua.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            ListaDeDados.Text = "";
        }
        void acharUltimoId(ref int cont)
        {
            SqlConnection conexao = new SqlConnection("Data Source=COROLA;Initial Catalog=dbAgenda;Integrated Security=True");
            try
            {
                string ultimoId = "select MAX(id) from empregado";
                //se der erro coloca a conexao aqui
                SqlCommand comando = new SqlCommand(ultimoId, conexao);
                comando.Parameters.AddWithValue("@pesquisa", pesquisaNome.Text);
                conexao.Open();
                SqlDataReader lista = comando.ExecuteReader();
                if (lista.Read())
                    cont = (int)lista.GetSqlInt32(0); //para achar o Id do empregado
                conexao.Close();
            }
            catch (Exception erro)
            {
                conexao.Close();
                MessageBox.Show(erro.Message);
            }
        }
        void listagemDeNomes()
        {
            int cont = 0;
            acharUltimoId(ref cont);
            SqlConnection conexao = new SqlConnection("Data Source=COROLA;Initial Catalog=dbAgenda;Integrated Security=True");
            for (int i = 1; i <= cont; i++)
            {
                try
                {
                    string busca = "select nome, rua, bairro, cidade from empregado where id = @idDoIncremento";
                    //se der erro coloca a conexao aqui
                    SqlCommand comando = new SqlCommand(busca, conexao);
                    comando.Parameters.AddWithValue("@idDoIncremento", i);
                    conexao.Open();
                    SqlDataReader lista = comando.ExecuteReader();
                    if (lista.Read())
                        ListaDeDados.Text += lista.GetString(0) + ", " + lista.GetString(1) + ", " + lista.GetString(2) + ", " + lista.GetString(3)+"\n";
                    conexao.Close();
                }
                catch (Exception erro)
                {
                    conexao.Close();
                    MessageBox.Show(erro.Message);
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string insert1 = "insert into empregado values(@nome, @ddd, @contato, @cpf, @salario, @departamento, @numCasa, @rua, @bairro, @cidade)";
            /*if (txtSalario.Text == "")
                MessageBox.Show("Caixa salario vazia");
            else*/
            string msg = "Insert realizado";
            InsersaoDeDados(insert1, msg);
            LimparOpcoes();
        }

        private void txtdddPessoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ConsultarDados();
        }

        private void txtConsultaNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparOpcoes();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string update1 = "update empregado set nome = @nome, ddd = @ddd, celular = @contato, cpf = @cpf, salario = @salario, departamento = @departamento, numCasa = @numCasa, rua = @rua, bairro = @bairro, cidade = @cidade where id = @id";
            string msg = "Update realizado";
            InsersaoDeDados(update1, msg);
            LimparOpcoes();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            string update1 = "delete from empregado where id = @id";
            string msg = "Delete realizado";
            InsersaoDeDados(update1, msg);
            LimparOpcoes();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listagemDeNomes();
        }
    }
}
