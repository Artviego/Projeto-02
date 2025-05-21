using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public class Usuario
    {
        private string nome;
        private string email;
        private string senha;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public bool verificarEmail(string email)
        {
            string emailValido = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(emailValido);
            return regex.IsMatch(email);
        }

        public string CriptografarSenha(string senha)
        {
            try
            {
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(senha));
                    StringBuilder builder = new StringBuilder();
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        builder.Append(bytes[i].ToString("x2"));
                    }

                    return builder.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível criptografar a senha: " + ex.Message, "Erro - Método Criptografar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ("");
            }
        }

        public bool CadastrarUsuario()
        {
            try
            {
                using (MySqlConnection conexaoBanco = new ConexaoDB().Conectar())
                {
                    string senhaCriptografada = CriptografarSenha(Senha);
                    string insert = "insert into usuario (nome, email, senha) values (@nome, @email, @senha);";

                    MySqlCommand comando = new MySqlCommand(insert, conexaoBanco);

                    comando.Parameters.AddWithValue("@nome", Nome);
                    comando.Parameters.AddWithValue("@email", Email);
                    comando.Parameters.AddWithValue("@senha", Senha);

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
                MessageBox.Show("Erro ao cadastrar o usuário -> Método " + ex.Message, "Erro - Cadastrar Usuário DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool verificarLogin()
        {
            try
            {
                using (MySqlConnection conexaoBanco = new ConexaoDB().Conectar())
                {
                    string senhaCriptografada = CriptografarSenha(Senha);
                    string consultaUsuarios = "select count(*) from usuario where email = @email and senha = @senha";

                    MySqlCommand comando = new MySqlCommand(consultaUsuarios, conexaoBanco);

                    comando.Parameters.AddWithValue("@email", Email);
                    comando.Parameters.AddWithValue("@senha", senhaCriptografada);

                    int resultado = Convert.ToInt32(comando.ExecuteScalar());

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
                MessageBox.Show("Erro ao verificar login no banco -> " + ex.Message);
                return false;
            }
        }

        public string buscarNome()
        {
            try
            {
                using (MySqlConnection conexaoBanco = new ConexaoDB().Conectar())
                {
                    string senhaCriptografada = CriptografarSenha(Senha);
                    string buscarNomeUsuario = "select from usuario where email = @email and senha = @senha";

                    MySqlCommand comando = new MySqlCommand(buscarNomeUsuario, conexaoBanco);

                    comando.Parameters.AddWithValue("@email", Email);
                    comando.Parameters.AddWithValue("@senha", senhaCriptografada);

                    object resultado = comando.ExecuteScalar();

                    if (resultado != null)
                    {
                        return resultado.ToString();
                    }
                    else
                    {
                        return "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível buscar pelo nome do usuário" + ex.Message);
                return "";
            }
        }
    }
}
