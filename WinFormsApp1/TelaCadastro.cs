using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class TelaCadastro : Form
    {
        public TelaCadastro(FormLogin formLogin)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtNome.Text.Equals("") && !txtEmail.Text.Equals("") && !txtSenha.Text.Equals(""))
                {
                    Usuario usuario = new Usuario();
                    usuario.Nome = txtNome.Text;
                    usuario.Email = txtEmail.Text;
                    usuario.Senha = txtSenha.Text;

                    if (usuario.verificarEmail(txtEmail.Text))
                    {
                        if (usuario.CadastrarUsuario())
                        {
                            MessageBox.Show("Usuário cadastrado com sucesso!");

                            txtNome.Clear();
                            txtEmail.Clear();
                            txtEmail.Clear();
                            txtSenha.Clear();

                            FormLogin telaLogin = new FormLogin();
                            telaLogin.Show();
                            Application.Exit();
                        }
                        else
                        {
                            MessageBox.Show("Falha ao cadastrar usuário");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Favor inserir um e-mail válido");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha os campos corretamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar usuário: " + ex.Message);
            }
        }
    }
}
