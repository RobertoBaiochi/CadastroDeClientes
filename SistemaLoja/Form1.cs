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
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            ModalAdd modal = new ModalAdd();

            if (modal.ShowDialog() == DialogResult.OK )
            {
                Cliente cliente = new Cliente
                {
                    Nome = modal.NomeCliente,
                    Endereco = modal.EnderecoCliente,
                    Cidade = modal.CidadeCliente
                };

                clientes.Add( cliente );
            }

            Listar();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
  
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int index = Lista.SelectedIndex;
            clientes.RemoveAt(index);
            Listar();
        }

        private void Lista_MouseDoubleClick(object sender, MouseEventArgs e)
        {

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
