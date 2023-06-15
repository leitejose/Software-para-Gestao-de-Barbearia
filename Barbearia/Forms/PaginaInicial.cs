using LoginForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barbearia.Forms
{
    public partial class PaginaInicial : Form
    {
        public PaginaInicial()
        {
            InitializeComponent();
        }

        private void PaginaInicial_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 1000; // Atualiza a cada 1 segundo
            timer.Tick += Timer_Tick;
            timer.Start();

           
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            
            LblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clientes frmClientes = new Clientes();
            frmClientes.ShowDialog();

            frmClientes.Closed += (s, args) => this.Close();
            frmClientes.Show();
        }
    }
}
