using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP
{
    internal class EnviarEmailSRP
    {
        public string EMailFrom { get; set; }
        public string EMailTo { get; set; }
        public string EMailSubject { get; set; }
        public string EMailBody { get; set; }

        public void Enviar()
        {
            MailMessage mailMessage =
                new MailMessage(EMailFrom, EMailTo, EMailSubject, EMailBody);
        }
    }
}
