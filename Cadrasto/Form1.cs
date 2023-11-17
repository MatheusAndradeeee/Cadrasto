using AppGunaExemplo.Configuracao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadrasto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Inserir();
            Consultar();
            label15.Text = "";
        }

        void Inserir()
        {
            var nomeFunc = "João da Silva Neto";
            var cpfFunc = "123.131.131-12";

            try
            {

                Conexao conexao = new Conexao();

                var comando = conexao.Comando("INSERT INTO funcionario (nome_func, cpf_func) VALUES (@nome, @cpf)");

                comando.Parameters.AddWithValue("@nome", nomeFunc);
                comando.Parameters.AddWithValue("@cpf", cpfFunc);
                var resultado = comando.ExecuteNonQuery();

                if (resultado > 0)
                {
                    MessageBox.Show("Funcionário cadastrado com sucesso");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Consultar()
        {
            try
            {
                var conexao = new Conexao();
                var comando = conexao.Comando("SELECT * FROM funcionario");
                var leitor = comando.ExecuteReader();

                string resultado = null;

                while (leitor.Read())
                {
                    resultado += "\n" + leitor.GetString("nome_func");
                }
                MessageBox.Show(resultado);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void label11_Click(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Validacao a = new Validacao();


            string nome = tx_Nome.Text;
            string cpf = tx_Cpf.Text;
            string rg = tx_Rg.Text;
            string estado_civi = tx_Estado_civ.Text;
            string telefone = tx_Telefone.Text;
            string email = tx_Email.Text;
            string endereco = tx_endereco.Text;
            string cidade = tx_cidade.Text;
            string estado = tx_Estado.Text;
            string data_Nasc = tx_Data_Nasc.Text;
            string salario = tx_Salario.Text;
            string funcao = tx_funcao.Text;

            bool aa = a.ValidarCpf(cpf);
            if (aa == true) { label15.Text = "Válido"; }
            else { label15.Text = "Inválido"; }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tx_Nome.Text = string.Empty;
            tx_Cpf.Text = string.Empty;
            tx_Rg.Text = string.Empty;
            tx_Estado_civ.Text = string.Empty;
            tx_Telefone.Text = string.Empty;
            tx_Email.Text = string.Empty;
            tx_endereco.Text = string.Empty;
            tx_cidade.Text = string.Empty;
            tx_Estado.Text = string.Empty;
            tx_Data_Nasc.Text = string.Empty;
            tx_Salario.Text = string.Empty;
            tx_funcao.Text = string.Empty;
        }
    }
}
