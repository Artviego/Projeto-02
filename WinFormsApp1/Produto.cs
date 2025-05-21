using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public class Produto
    {
        private string nome;
        private string descricao;
        private decimal preco;
        private int quantidade;

        public string Nome
        {
            get { return nome; }
            set { value = nome; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { value = descricao; }
        }

        public decimal Preco
        {
            get { return preco; }
            set { value = preco; }
        }

        public int Quantidade
        {
            get { return quantidade; }
            set { value = quantidade; }
        }

        public bool CadastrarProduto()
        {
            try
            {
                using (MySqlConnection conexaoBanco = new ConexaoDB().Conectar())
                {
                    string cadastrar = "insert into produto (Nome, Descricao, Preco, Quantidade) values (@nome, @descricao, @preco, @quantidade);";

                    MySqlCommand comando = new MySqlCommand(cadastrar, conexaoBanco);

                    comando.Parameters.AddWithValue("@nome", Nome);
                    comando.Parameters.AddWithValue("@descricao", Descricao);
                    comando.Parameters.AddWithValue("@preco", Preco);
                    comando.Parameters.AddWithValue("@quantidade", Quantidade);

                    int resultado = comando.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o produto - Método -> " + ex.Message, "Erro - Cadastrar Produto DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool AtualizarProduto()
        {
            try
            {
                using (MySqlConnection conexaoBanco = new ConexaoDB().Conectar())
                {
                    string atualizaProduto = "update produto set descricao = @Descricao, preco = @Preco, quantidade = @quantidade where nome = @nome";

                    MySqlCommand comando = new MySqlCommand(atualizaProduto, conexaoBanco);

                    comando.Parameters.AddWithValue("@Nome", Nome);
                    comando.Parameters.AddWithValue("@Descricao", Descricao);
                    comando.Parameters.AddWithValue("@Preco", Preco);
                    comando.Parameters.AddWithValue("@Quantidade", Quantidade);

                    conexaoBanco.Open();

                    int resultado = comando.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível atualizar o produto -> " + ex.Message, "Erro - Atualizar Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool ExcluirProduto()
        {
            try
            {
                using (MySqlConnection conexaoBanco = new ConexaoDB().Conectar())
                {
                    string excluirProduto = "delet from Produto where nome = @nome";

                    MySqlCommand comando = new MySqlCommand(excluirProduto, conexaoBanco);

                    comando.Parameters.AddWithValue("@nome", Nome);

                    int resultado = comando.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível excluir o produto - Método ->" + ex.Message, "Erro - Excluir Setor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static List<Produto> ListarTodosProdutos()
        {
            List<Produto> produtos = new List<Produto>();

            using (MySqlConnection conexaoBanco = new ConexaoDB().Conectar())
            {
                string listarProdutos = "select * from produto";

                MySqlCommand comando = new MySqlCommand(listarProdutos, conexaoBanco);

                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    produtos.Add(new Produto
                    {
                        Nome = reader.GetString("Nome"),
                        Descricao = reader.GetString("Descricao"),
                        Preco = reader.GetDecimal("Preco"),
                        Quantidade = reader.GetInt32("Quantidade")
                    });
                }
            }
            return produtos;
        }

    }
}
