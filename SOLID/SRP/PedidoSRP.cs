using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP
{
    internal class PedidoSRP
    {
        private EnviarEmailSRP enviarEmail;
        private RegistrarLogSRP infoLogger;

        public long Quantidade { get; set; }
        public DateTime Data { get; set; }

        public PedidoSRP()
        {
            enviarEmail = new EnviarEmailSRP();
            infoLogger = new RegistrarLogSRP();
        }

        // Responsabilidade OK
        public void IncluirPedido()
        {
            try
            {
                // Código para incluir pedido
                // Após incluir, envia o email

                // Log OK
                infoLogger.Info("Incluindo pedido...");

                // Enviando email - SRP OK
                enviarEmail.EMailFrom = "emailfrom@email.com";
                enviarEmail.EMailTo = "emailto@email.com";
                enviarEmail.EMailSubject = "SRP";
                enviarEmail.EMailBody = "SOLID";

                enviarEmail.Enviar();

            }
            catch (Exception ex)
            {
                // Log OK
                infoLogger.Info(ex.ToString());
            }
        }

        // Responsabilidade OK
        public void DeletarPedido()
        {
            try
            {
                // Código para deletar pedido

                // Log OK
                infoLogger.Info("Deletando pedido...");
            }
            catch (Exception ex)
            {
                // Log OK
                infoLogger.Info(ex.ToString());
            }
        }
    }
}
