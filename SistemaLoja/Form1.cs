using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaLoja
{
    public partial class Form1 : Form
    {

        List<Cliente> clientes;


        public Form1()
        {
            InitializeComponent();

            clientes = new List<Cliente>();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Acrescentar Login
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Modal modal = new Modal();
            modal.LabelModal = "Adcionar Cliente";

            if (modal.ShowDialog() == DialogResult.OK)
            {
                Cliente cliente = new Cliente
                {
                    Nome = modal.NomeCliente,
                    Endereco = modal.EnderecoCliente,
                    Cidade = modal.CidadeCliente
                };

                if (cliente.Nome != "" && cliente.Endereco != "" && cliente.Cidade != "")
                {
                    clientes.Add(cliente);
                }
            }

            Listar();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            int index = Lista.SelectedIndex;

            if (index < 0) return;

            Modal modal = new Modal();
            modal.LabelModal = "Editar Cliente";

            modal.NomeCliente = clientes[index].Nome;
            modal.EnderecoCliente = clientes[index].Endereco;
            modal.CidadeCliente = clientes[index].Cidade;

            if (modal.ShowDialog() == DialogResult.OK)
            {
                clientes[index].Nome = modal.NomeCliente;
                clientes[index].Endereco = modal.EnderecoCliente;
                clientes[index].Cidade = modal.CidadeCliente;
            }

            Listar();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int index = Lista.SelectedIndex;
            if (index < 0) return;
            clientes.RemoveAt(index);
            Listar();
        }

        private void Lista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnEdit_Click(btnEdit, EventArgs.Empty);

        }

        private void Listar()
        {
            Lista.Items.Clear();

            foreach (Cliente cliente in clientes)
            {
                Lista.Items.Add($"ID: {cliente.ID} ## Nome: {cliente.Nome} - Endereço: {cliente.Endereco} - Cidade: {cliente.Cidade}.");
            }
        }

    }
}
