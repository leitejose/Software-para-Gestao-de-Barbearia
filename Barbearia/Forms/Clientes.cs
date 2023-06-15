using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barbearia.Forms
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdoDataSet);

        }

        private void clienteBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdoDataSet);

        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdoDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.bdoDataSet.Cliente);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<TextBox> lstTextbox = new List<TextBox> { idTextBox, nomeTextBox, emailTextBox, nIFTextBox, telemovelTextBox, moradaTextBox };
            foreach (TextBox campo in lstTextbox)
            {
                campo.ReadOnly = false;
            }

            // Adicione outros campos de texto aqui
        }

        // Itera sobre a lista de campos de texto


        private void groupBoxClientesCadastrados_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int newId = Convert.ToInt32(idTextBox.Text);
                string newName = nomeTextBox.Text;
                string newEmail = emailTextBox.Text;
                int newNIF = Convert.ToInt32(nIFTextBox.Text);
                int newNumberTelemovel = Convert.ToInt32(telemovelTextBox.Text);
                string newMorada = moradaTextBox.Text;

                clienteTableAdapter.UpdateQueryModifyClient(newName, newNIF, newEmail, newMorada, newNumberTelemovel, newId);
                MessageBox.Show("Cliente atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar o usuário: " + ex.Message);
            }
        }
    }
}




