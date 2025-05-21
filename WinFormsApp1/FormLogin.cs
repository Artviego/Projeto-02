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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaCadastro telaCadastro = new TelaCadastro(this);
            telaCadastro.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtEmail.Text.Equals("") && !txtSenha.Text.Equals(""))
                {
                    Usuario usuario = new Usuario();
                    usuario.Email = txtEmail.Text;
                    usuario.Senha = txtSenha.Text;

                    if (usuario.verificarEmail(txtEmail.Text))
                    {
                        if (usuario.verificarLogin())
                        {
                            MessageBox.Show("Login realizado com sucesso");
                            string nomeLogado = usuario.buscarNome();
                            Form sistema = new Form();
                            sistema.Show();
                            Application.Exit();
                        }
                        else
                        {
                            MessageBox.Show("Usuário ou senha inválidos");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Digite um e-mail válido");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha os campos corretamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no login -> " + ex.Message, "Erro - Método Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
