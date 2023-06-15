using LoginForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Barbearia.Forms
{
    public partial class RecuperarSenhas : Form
    {
        public RecuperarSenhas()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginSistema frmReturnLogin = new LoginSistema();
            frmReturnLogin.ShowDialog();

            frmReturnLogin.Closed += (s, args) => this.Close();
            frmReturnLogin.Show();
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            string senha = "senha123";
           string email = "joseleite688@gmail.com";
            string nome = "Jose";

            try
            {
                // Configurar as credenciais do remetente (sua conta de email do Gmail)
                string remetenteEmail = "joseneto20222022@outlook.pt";
                string remetenteSenha = "NosVamosProgramar";

                // Configurar o servidor SMTP do Gmail
                SmtpClient smtpClient = new SmtpClient("smtp.office365.com", 587);
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(remetenteEmail, remetenteSenha);

                // Criar a mensagem de email
                MailMessage mensagem = new MailMessage();
                mensagem.From = new MailAddress(remetenteEmail);
                mensagem.To.Add(new MailAddress(email));
                mensagem.Subject = "Recuperação de Senha";
                mensagem.Body = $"Olá {nome},\n\n Sua senha é: {senha}";

                // Enviar o email
                smtpClient.Send(mensagem);

                // Exibir a senha recuperada para fins de demonstração
                MessageBox.Show($"Olá {nome} Sua senha foi enviada para o email: {email}");

                
            }
            catch (Exception ex)
            {
                // Lidar com exceções ao enviar o email
                MessageBox.Show($"Ocorreu um erro ao enviar o email: {ex.Message}");
                
            }

        }

        
        }

    }


