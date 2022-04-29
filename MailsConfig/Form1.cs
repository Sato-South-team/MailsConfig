using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailsConfig
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("puttuh12@gmail.com");
                //message.To.Add(new MailAddress("darshan.kumar.a9k@ap.denso.com"));
                message.To.Add(new MailAddress("puttaraju.ah@sato-global.com"));

                message.Subject = "DIE";
                // message.IsBodyHtml = true; //to make message body as html  
                // message.Body = "FOR YOUR INFORMATION, THE MENTIONED DIE, 640A BRAKET IS ON PM STAGE, PLEASE COMPLET THE PM ACTIVIY TO THIS DIE";
                message.Body = "HI";

                smtp.Port = 587;
                //smtp.Host = "210.236.247.59"; //for gmail host
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                // smtp.Credentials = new System.Net.NetworkCredential("dnkismtp", "gq29U9viorURWbD4AnFU");
                smtp.Credentials = new System.Net.NetworkCredential("puttuh12@gmail.com", "@Ka05em2845");

                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                ServicePointManager.ServerCertificateValidationCallback =
       delegate (
           object s,
           X509Certificate certificate,
           X509Chain chain,
           SslPolicyErrors sslPolicyErrors
       ) {
           return true;
       };
                smtp.Send(message);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
