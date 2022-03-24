using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtocoloEmail
{
    public partial class uFormInformacao : Form
    {
        public uFormInformacao()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void uFormInformacao_Load(object sender, EventArgs e)
        {
            groupBox1.Text = "\n " +
                             "Cada e-mail tem o endereço do remetente (por exemplo, remetente@email.com.br) e sua senha de login (por exemplo, !@#ROOT). \n" +
                             "E para o destinatário(por exemplo, destinatario @email.com.br). \n" +
                             "Onde caso o endereço do remetente e do destinatário, quando um e-mail é enviado, o provedor de e-mail se conecta ao servidor SMTP do serviço de e-mail do remetente. \n" +
                             "O provedor transmite o endereço do remetente, o endereço do destinatário e o conteúdo da mensagem. \n" +
                             "Assim, o servidor SMTP trabalha para localizar o paradeiro do destinatário.Usando o ID de e-mail do destinatário, ele localiza o nome do domínio.\n\n" +
                             "Nesse “simulador” é possível também enviar emails a um destinatário real.\n" +
                             "Basta marcar a opção de enviar e-mail de forma real ao destinatário.\n" +
                             "Caso ao tentar enviar o email de forma real e o servidor seja o Gmail, e aconteça o erro em que o servidor SMTP requer uma conexão segura ou o cliente não foi autenticado.\n" +
                             "Nas configurações da conta:\n" +
                             "Procure pela opção ''Acesso menos seguro'', ou entre aqui: https://myaccount.google.com/lesssecureapps \n" +
                             "Ativa a opção de 'Acesso menos seguro' (isso só será possível se sua conta não possuir autenticação por 2 fatores)\n";
        }
    }
}
