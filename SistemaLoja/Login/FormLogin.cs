using System;
using System.Windows.Forms;

namespace SistemaLoja.Login
{
    public partial class FormLogin : Form
    {
        public static bool Cancelar = false;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnCancelarLogin_Click(object sender, EventArgs e)
        {
            Cancelar = true;
            Close();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string nome = txtNomeLogin.Text;
            string senha = txtSenhaLogin.Text;

            if (nome == "")
            {
                MessageBox.Show("Preencha o campo de Nome/Usuário");
                txtNomeLogin.Focus();
                return;
            }

            if (senha == "")
            {
                MessageBox.Show("Preencha o campo da Senha");
                txtSenhaLogin.Focus();
                return;
            }

            if (UsuarioLogin.FazerLogin(nome, senha))
            {
                Close();
            }
            else
            {
                MessageBox.Show("Acesso Negado");
                txtNomeLogin.Text = string.Empty;
                txtSenhaLogin.Text = string.Empty;
                txtNomeLogin.Focus();
                Close();
            }
        }
    }
}
