﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AgendaTelefonica
{
    public partial class Form1 : Form
    {
        //Variavel para armazenar o id do produto que será alterado ou apagado
        int controleID = 0;

        //Método para fazer insert, update e delete no banco
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
                comando.Parameters.AddWithValue("@salario", txtSalario.Text.Replace(",","."));
                comando.Parameters.AddWithValue("@departamento", txtDepartamento.Text);
                comando.Parameters.AddWithValue("@numCasa", numCasa.Text);
                comando.Parameters.AddWithValue("@rua", txtRua.Text);
                comando.Parameters.AddWithValue("@bairro", txtBairro.Text);
                comando.Parameters.AddWithValue("@cidade", txtCidade.Text);
                comando.Parameters.AddWithValue("@sexo", txtSexo.Text);
                comando.Parameters.AddWithValue("@id", controleID);
                comando.Parameters.AddWithValue("@estadoCivil", estadoCivil.Text);
                comando.Parameters.AddWithValue("@cep", txtCep.Text);
                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show(alerta);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "erro no metodo InsersaoDeDados()");
                conexao.Close();
            }
        }

        //Método para trazer os dados do banco e inserir no formulário
        void ConsultarDados()
        {
            string consulta = "";
            try
            {
                if (opcaoCpfOuNome.Text == "Nome")
                    consulta = "select nome, ddd, celular, cpf, salario, departamento, numCasa, rua, bairro, cidade, id, sexo, estadoCivil, cep from empregado where nome = @pesquisa";
                else
                    consulta = "select nome, ddd, celular, cpf, salario, departamento, numCasa, rua, bairro, cidade, id, sexo, estadoCivil, cep from empregado where cpf = @pesquisa";


                SqlConnection conexao = new SqlConnection("Data Source=COROLA;Initial Catalog=dbAgenda;Integrated Security=True");
                SqlCommand comando = new SqlCommand(consulta, conexao);
                comando.Parameters.AddWithValue("@pesquisa", pesquisaNome.Text);//"pesquisaNome" é a caixa de texto que será usada 
                conexao.Open();                                                 //na clausula where para fazer a consulta
                SqlDataReader lista = comando.ExecuteReader();
                if (lista.Read())
                {
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
                    controleID = (int)lista.GetSqlInt32(10); //passa o id do empregado para a variável controleId
                    txtSexo.Text = lista.GetString(11);
                    estadoCivil.Text = lista.GetString(12);
                    txtCep.Text = lista.GetSqlInt32(13).ToString();
                }
                else
                {
                    MessageBox.Show("O nome especificado não foi localizado");
                }

                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " erro no metodo ConsultarDados()");
            }
        }

        //O metodo LimparOpcoes coloca uma string vazia em todas as textBox
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
            estadoCivil.Text = "";
            txtSexo.Text = "";
            txtCep.Text = "";
            pesquisaNome.Text = "";
        }

        //O método validarCampos faz a validação de todos os textBox e comboBox, caso estejam invalidas ele inpede a alteração no banco
        bool validarCampos()
        {
            string camposVazios = "";
            if (txtPessoa.Text == "")
                camposVazios += "nome, ";
            if (txtdddPessoa.Text == "")
                camposVazios += "DDD, ";
            if (txtNumero.Text == "")
                camposVazios += "número, ";
            if (txtCpf.Text == "")
                camposVazios += "cpf, ";
            if (txtDepartamento.Text == "")
                camposVazios += "departamento, ";
            if (txtRua.Text == "")
                camposVazios += "rua, ";
            if (txtBairro.Text == "")
                camposVazios += "bairro, ";
            if (txtCidade.Text == "")
                camposVazios += "cidade, ";
            if (estadoCivil.Text == "")
                camposVazios += "estado civíl, ";
            if (txtSexo.Text == "")
                camposVazios += "sexo, ";

            try
            {
                double salario = double.Parse(txtSalario.Text);
            }
            catch
            {
                camposVazios += " salario, ";
            }
            try
            {
                double numeroDaCasa = double.Parse(numCasa.Text);
            }
            catch
            {
                camposVazios += " número da casa, ";
            }
            try
            {
                double cep = double.Parse(txtCep.Text);
            }
            catch
            {
                camposVazios += " cep ";
            }

            if (camposVazios != "")
            {
                camposVazios += " vazio ou inválido";
                MessageBox.Show(camposVazios);
                return false;
            }
            else
                return true;
        }

        //O médoto acharUltimoId faz um select na tabela empregado que retorna o id do ultimo empregado
        //esse método é importante porque o retorno dele será usado em um laço for que irá percorrer a tabela empregado
        void acharUltimoId(ref int cont)
        {
            SqlConnection conexao = new SqlConnection("Data Source=COROLA;Initial Catalog=dbAgenda;Integrated Security=True");
            try
            {
                string ultimoId = "select MAX(id) from empregado";
                SqlCommand comando = new SqlCommand(ultimoId, conexao);
                comando.Parameters.AddWithValue("@pesquisa", pesquisaNome.Text);
                conexao.Open();
                SqlDataReader lista = comando.ExecuteReader();
                if (lista.Read())
                    cont = (int)lista.GetSqlInt32(0);
                conexao.Close();
            }
            catch (Exception erro)
            {
                conexao.Close();
                MessageBox.Show(erro.Message + " erro no metodo acharUltimoId()");
            }
        }

        //listagemDeNomes adiciona a caixa de texto "ListaDeDados" todos os cadastrados no banco
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
                    SqlCommand comando = new SqlCommand(busca, conexao);
                    comando.Parameters.AddWithValue("@idDoIncremento", i);
                    conexao.Open();
                    SqlDataReader lista = comando.ExecuteReader();
                    if (lista.Read())
                        ListaDeDados.Text += lista.GetString(0) + ", " + lista.GetString(1) + ", " + lista.GetString(2) + ", " + lista.GetString(3) + "\n";
                    conexao.Close();
                }
                catch (Exception erro)
                {
                    conexao.Close();
                    MessageBox.Show(erro.Message + " erro no metodo ListagemDeNomes()");
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
        
        //Botão para salvar um novo cadastro
        private void button1_Click(object sender, EventArgs e)
        {
            string insert = "insert into empregado values(@nome, @ddd, @contato, @cpf, @salario, @departamento, @numCasa, @rua, @bairro, @cidade, @sexo, @estadoCivil, @cep)";
            string msg = "Insert realizado";
            if (validarCampos())
            {
                InsersaoDeDados(insert, msg);
                LimparOpcoes();
            }
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


        //Botão para para limpar as opções do cadastro *Atenção, não é para cancelar é para limpar as opções
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparOpcoes();
        }


        //Botão para atualizar a cadastro de algum funcionário já cadastrado
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string update1 = "update empregado set nome = @nome, ddd = @ddd, celular = @contato, cpf = @cpf, salario = @salario, departamento = @departamento, numCasa = @numCasa, rua = @rua, bairro = @bairro, cidade = @cidade, sexo = @sexo, estadoCivil = @estadoCivil, cep = @cep where id = @id";
            string msg = "Update realizado";
            if (validarCampos())
            {
                InsersaoDeDados(update1, msg);
                LimparOpcoes();
            }
        }

        //Botão para apagar o cadastro do funcionário selecionado
        private void btnApagar_Click(object sender, EventArgs e)
        {
            string update1 = "delete from empregado where id = @id";
            string msg = "Delete realizado";
            InsersaoDeDados(update1, msg);
            LimparOpcoes();
        }

        //Botão para listar todos os usuários cadastrados na caixa de texto
        private void button1_Click_1(object sender, EventArgs e)
        {
            listagemDeNomes();
        }
    }
}
