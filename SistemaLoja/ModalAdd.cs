using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLoja
{
    public partial class ModalAdd : Form
    {

        public string NomeCliente { get; set; }
        public string EnderecoCliente { get; set; }
        public string CidadeCliente { get; set; }

        public ModalAdd()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            ClearInputs();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNome.Text))
            {
                NomeCliente = txtNome.Text;
            }

            if(!string.IsNullOrEmpty(txtEndereco.Text))
            {
                EnderecoCliente = txtEndereco.Text;
            }

            if(!string.IsNullOrEmpty(txtCidade.Text))
            {
                CidadeCliente = txtCidade.Text;
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
