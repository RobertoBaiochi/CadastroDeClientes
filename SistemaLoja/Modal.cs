using System;
using System.Windows.Forms;

namespace SistemaLoja
{
    public partial class Modal : Form
    {

        public string NomeCliente
        {
            get { return txtNome.Text; }
            set { txtNome.Text = value; }
        }
        public string EnderecoCliente
        {
            get { return txtEndereco.Text; }
            set { txtEndereco.Text = value; }
        }
        public string CidadeCliente
        {
            get { return txtCidade.Text; }
            set { txtCidade.Text = value; }
        }

        public string LabelModal
        {
            get { return lblCliente.Text; }
            set
            {
                lblCliente.Text = value;
            }
        }

        public Modal()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            ClearInputs();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Preencha o campo Nome!");
                txtNome.Focus();
                return;
            }

            if (txtEndereco.Text == "")
            {
                MessageBox.Show("Preencha o campo Endereço!");
                txtEndereco.Focus();
                return;
            }

            if (txtCidade.Text == "")
            {
                MessageBox.Show("Preencha o campo Cidade!");
                txtCidade.Focus();
                return;
            }

        }

        private void ClearInputs()
        {
            txtNome.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtEndereco.Text = string.Empty;
        }
    }
}
