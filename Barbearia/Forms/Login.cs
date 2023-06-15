
using Barbearia.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LoginForm
{
    public partial class LoginSistema : Form
    {
        public LoginSistema()
        {
           InitializeComponent();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            /* SqlConnection con = new SqlConnection(@"Data Source=USER;Initial Catalog=admin;Integrated Security=True"); // making connection   
             SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Usuarios WHERE Utilizador='" + textBoxUtilizador1.Text + "' AND Senha='" + textBoxSenha.Text + "'", con);*/
            try {
                int percorrerBaseUsuarios = 0;
                percorrerBaseUsuarios = (int)usuariosTableAdapter1.ScalarQueryByUserAndPass(
                    textBoxSenha.Text,
                    textBoxUtilizador1.Text);

                if (percorrerBaseUsuarios == 1) 
                    { 

                        

                    PaginaInicial AbrirPagina = new PaginaInicial();
                    AbrirPagina.Show();
                    // Credenciais corretas, realizar login
                    MessageBox.Show("Login bem-sucedido!");

                    // Redirecionar para a próxima tela ou realizar outras ações necessárias
                }
                    else
                    {
                    // Credenciais incorretas
                    MessageBox.Show("Usuário ou senha inválidos!");
                    }
                }
                catch (Exception ex)
                {
                    // Lidar com exceções
                    MessageBox.Show("Ocorreu um erro: " + ex.Message);
                }
}

        private LoginSistema GetLoginSistema()
        {
            return this;
        }

        private void linkLabelRecuperarSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RecuperarSenhas frm = new RecuperarSenhas();
            frm.ShowDialog();
     
        frm.Closed += (s, args) => this.Close(); 
        frm.Show();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnContate_Click(object sender, EventArgs e)
        {
            string url = "https://portifoliojoseleite.vercel.app/"; // URL do site para o qual deseja direcionar

            System.Diagnostics.Process.Start(url);
        }

        private void textBoxUtilizador1_TextChanged(object sender, EventArgs e)
        {

        }
    }

       
    }

