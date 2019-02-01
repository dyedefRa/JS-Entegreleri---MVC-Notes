using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailOlayi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailMessage msg = new MailMessage();
            MailAddress alici = new MailAddress("bkztrk@gmail.com");
            MailAddress yollayan = new MailAddress("Aklinsonu@gmail.com", "EXE", Encoding.UTF8);
            msg.To.Add(alici);
            msg.Subject = "BAHALE";
            msg.IsBodyHtml = true;
            msg.From = yollayan;
            msg.Body = "<a href='https://www.google.com.tr/'> Onay için tıkla </a>";
            SmtpClient smp= new SmtpClient();
            smp.Credentials = new NetworkCredential("Aklinsonu@gmail.com", "297232100889a");
            smp.Port = 587;
            smp.Host = "smtp.gmail.com";
            smp.EnableSsl = true;
            smp.Send(msg);
        }
    }
}
