using System;
using System.Globalization;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ProtocoloEmail
{
    public partial class email : Form
    {
        int FQuantidadeEnvios = 0;

        public email()
        {
            InitializeComponent();
        }

        private bool CheckCamposObrigatorios()
        {
            if ((string.IsNullOrEmpty(TextBoxEmailRem.Text)) || 
                (string.IsNullOrEmpty(TextBoxSenha.Text)) ||
                (string.IsNullOrEmpty(TextBoxEmailDest.Text)) ||
                (string.IsNullOrEmpty(TextBoxAssunto.Text)) ||
                (string.IsNullOrEmpty(TextBoxMensagem.Text)))
            {
                return false;
            } 
            else
            {
                return true;
            }    
        }

        private bool VerificarServidorEmail(string prEmail)
        {
            //ATRIBUI A EXPRESSAO REGEX
            Regex regExpEmailServer = new Regex(@"@[a-z]+\.[a-z]{2,3}");

            //VALIDA A EXPRESSAO
            Match match = regExpEmailServer.Match(prEmail);

            if (match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool VerificarEmail(string prEmail)
        {
            //ATRIBUI A EXPRESSAO REGEX
            Regex regExpEmail = new Regex(@"^[a-zA-Z]+(([\'\,\.\- ][a-zA-Z ])?[a-zA-Z]*)*\s+<(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,3})>$|^(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,3})$");

            //VALIDA A EXPRESSAO
            Match match = regExpEmail.Match(prEmail);

            if (match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string FormatarData(DateTime prData)
        {
            string vFormato       = "r";
            string vDataFormatada = "";

            for (int i = 0; i < vFormato.Length; i++)
            {
                vDataFormatada = prData.ToString(vFormato, DateTimeFormatInfo.InvariantInfo);
                Console.WriteLine(string.Concat(vFormato, " :", vDataFormatada));
            }

            return vDataFormatada;
        }

        private string EnviaHeader(string prEmailRemetente, string prEmailDestinatario)
        {
            string vResult = "";

            vResult += "Snd: DATA\r\n";

            vResult += "Rcv: 353 End data with <CR><LF> <CR><LF>\r\n";

            vResult += "Snd: From: " + prEmailRemetente + "\r\n";
            vResult += "Snd: To: " + prEmailDestinatario + "\r\n";

            string vDataEnvio = FormatarData(DateTime.Now);

            vResult += "Snd: Date: " + vDataEnvio + "\r\n";

            return vResult;
        }

        private string EnviaBody(string prAssunto, string prMensagem)
        {
            string vResult = "";

            vResult += "Snd: Subject: " + prAssunto + "\r\n";
            vResult += "Snd: \r\n";

            vResult += "Snd: " + prMensagem + "\r\n";

            Random vNumeroAleatorio = new Random();
            int vNumeroFila = vNumeroAleatorio.Next(1, 10000);

            vResult += "Rcv: 250 Ok: queued at " + vNumeroFila + "\r\n";

            vResult += "Snd: QUITS\r\n";

            vResult += "Rcv: 221 Bye\r\n";
            vResult += "{The server closes the connection}";

            return vResult;
        }

        private void EnviarEmail(string prEmailRemetente, string prEmailDestinatario, string prAssunto, string prMensagem, string vSenha)
        {
            MailMessage mail = new MailMessage();

            mail.From = new MailAddress(prEmailRemetente);
            mail.Subject = prAssunto;
            mail.Body = prMensagem;

            mail.To.Add(prEmailDestinatario);

            using (var smtp = new SmtpClient("smtp.gmail.com", 587))
            {
                smtp.Credentials = new NetworkCredential(prEmailRemetente, vSenha);

                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;

                //ENVIO DO EMAIL
                try
                {
                    smtp.Send(mail);

                    MessageBox.Show("E-mail Enviado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Falha ao enviar e-mail");
                }
            }
        }

        private void BotaoEnviar_Click(object sender, EventArgs e)
        {
            //ALIMENTANDO VARIAVEIS COM OS CAMPOS DO TEXT BOX
            string vEmailDestinatario = TextBoxEmailDest.Text;
            string vEmailRemetente = TextBoxEmailRem.Text;
            string vMensagem = TextBoxMensagem.Text;
            string vProvedor = "";
            string vAssunto = TextBoxAssunto.Text;
            string vSenha = TextBoxSenha.Text;

            //CHECA O PRENCHIMENTO DOS CAMPOS
            if (!CheckCamposObrigatorios())
            {
                MessageBox.Show("Campos obrigatórios não prenchidos, para enviar a mensagem todos os campos devem ser preenchidos");
                return;
            }

            //GAMBIZINHA PARA MOSTRA O NUMERO DA REQUISIÇÃO
            FQuantidadeEnvios = FQuantidadeEnvios + 1;

            try
            {
                //BUSCA O SERVIDOR DE EMAIL DO REMETENTE
                string[] vServidor = vEmailRemetente.Split('@');
                vProvedor = vServidor[1];
            }
            catch
            {

            }

            TextBoxRequisicoes.Text += "\r\n============ REQUISIÇÃO NR " + FQuantidadeEnvios + " ============\r\n";

            TextBoxRequisicoes.Text += "Snd: HELO " + vProvedor + "\r\n";

            if (!VerificarServidorEmail(vEmailRemetente))
            {
                TextBoxRequisicoes.Text += "Rcv: 512 email domain in the CC is incorrect\r\n";

                MessageBox.Show("Ocorreu um erro na requisição SMTP");
                return;
            }
            else
            {
                TextBoxRequisicoes.Text += "Rcv: 250 Hello " + vProvedor + ", pleased to meet you\r\n";
            }

            //EMAIL REMETENTE
            TextBoxRequisicoes.Text += "Snd: MAIL FROM: <" + vEmailRemetente + ">\r\n";

            if (!VerificarEmail(vEmailRemetente))
            {
                TextBoxRequisicoes.Text += "Rcv: 510 email address in the 'CC' is incorrect\r\n";

                MessageBox.Show("Ocorreu um erro na requisição SMTP");
                return;
            }
            else
            {
                TextBoxRequisicoes.Text += "Rcv: 250 OK!\r\n";
            }

            //EMAIL DESTINATARIO
            TextBoxRequisicoes.Text += "Snd: RCPT TO: <" + vEmailDestinatario + ">\r\n";

            if (!VerificarEmail(vEmailDestinatario))
            {
                TextBoxRequisicoes.Text += "Rcv: 510 email address in the 'TO' is incorrect\r\n";

                MessageBox.Show("Ocorreu um erro na requisição SMTP");
                return;
            }
            else
            {
                TextBoxRequisicoes.Text += "Rcv: 250 OK!\r\n";
            }

            //ENVIA O CABEÇALHO DA REQUISICAO
            TextBoxRequisicoes.Text += EnviaHeader(vEmailRemetente, vEmailDestinatario);

            //ENVIA O CORPO DA REQUISICAO
            TextBoxRequisicoes.Text += EnviaBody(vAssunto, vMensagem);

            bool vEhEnviarEmail = checkBoxEnviarEmail.Checked;

            //FAZ A REQUISIÇÃO SMTP DE FORMA REAL PARA O SERVIDOR
            if (vEhEnviarEmail)
            {
                EnviarEmail(vEmailRemetente, vEmailDestinatario, vAssunto, vMensagem, vSenha);
            }
        }

        // MANTÉM O SCROLL SEMPRE PARA BAIXO
        private void TextBoxRequisicoes_TextChanged(object sender, EventArgs e)
        {
            TextBoxRequisicoes.SelectionStart = TextBoxRequisicoes.Text.Length;

            TextBoxRequisicoes.ScrollToCaret();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void instruçõesDeUsoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uFormInformacao vForm = new uFormInformacao();
            vForm.Show();
        }
    }
}
