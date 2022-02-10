using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP
{
    /***
     Essa classe está violando o SRP, pois está tendo mais que uma responsabilidade (enviar email, salvar log)
     ***/
    internal class Pedido
    {
        public long Quantidade { get; set; }
        public DateTime Data { get; set; }

        // Responsabilidade OK
        public void IncluirPedido()
        {
            try
            {
                // Código para incluir pedido
                // Após incluir, envia o email

                // Violação do SRP
                MailMessage mailMessage =
                    new MailMessage("EmailFrom", "EmailTo", "EmailSubject", "EmailBody");
            }
            catch (Exception ex)
            {
                // Violação do SRP
                File.WriteAllText(@"C:\Users\lcsef\Documents\Workspaces\dotnet-udemy\SOLID\Logs\ErrorLog.txt", ex.ToString());
            }
        }

        // Responsabilidade OK
        public void DeletarPedido()
        {
            try
            {
                // Código para deletar pedido
            }
            catch (Exception ex)
            {
                // Violação do SRP
                File.WriteAllText(@"C:\Users\lcsef\Documents\Workspaces\dotnet-udemy\SOLID\Logs\ErrorLog.txt", ex.ToString());
            }
        }

        // Violação do SRP
        public void EnviarEmailPedido(MailMessage mailMessage)
        {
            try
            {
                // Código para enviar
            }
            catch (Exception ex)
            {
                // Violação do SRP
                File.WriteAllText(@"C:\Users\lcsef\Documents\Workspaces\dotnet-udemy\SOLID\Logs\ErrorLog.txt", ex.ToString());
            }
        }

    }
}
