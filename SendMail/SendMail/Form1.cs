using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SendMail
{
    public partial class Form1 : Form
    {
        //設定画面
        private ConfigForm configFrom = new ConfigForm();

        private Settings settings = Settings.getInstance();

        public Form1()
        {
            InitializeComponent();
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            try
            {
                //メール送信のためのインスタンスを生成
                MailMessage mailMessage = new MailMessage();
                //差出人アドレス
                mailMessage.From = new MailAddress(settings.MailAddr);
                //宛先（To）
                
                
                mailMessage.To.Add(tbTo.Text);
                if (tbCc.Text!="")
                {
                    mailMessage.CC.Add(tbCc.Text);
                }
                if (tbCc.Text != "")
                {
                    mailMessage.Bcc.Add(tbBcc.Text);
                }
                //件名（タイトル
                mailMessage.Subject = tbTitle.Text;
                //本文
                mailMessage.Body = tbMessage.Text;
                if(tbMessage.Text == null || tbMessage.Text == string.Empty)
                {
                    MessageBox.Show("本文を打ち込んでください。");
                    return;
                }

                //SMTPを使ってメールを送信する
                SmtpClient smtpClient = new SmtpClient();
                //メール送信のための認証情報を設定（ユーザー名、パスワード）
                smtpClient.Credentials
                    = new NetworkCredential(settings.MailAddr,settings.Pass);
                smtpClient.Host = settings.Host;
                smtpClient.Port = settings.Port;
                smtpClient.EnableSsl = settings.Ssl;
                //smtpClient.Send(mailMessage,userState);

                //MessageBox.Show("送信完了");
                smtpClient.SendCompleted += SmtpClient_SendCompleted;

                //clear();
                string userState = "SendMail";

    
                smtpClient.SendAsync(mailMessage, userState);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SmtpClient_SendCompleted(object sender, AsyncCompletedEventArgs e)
        { 
            if(e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else
            {
                MessageBox.Show("送信完了");
                clear();
            }
        }

        private void btConfig_Click(object sender, EventArgs e)
        {
            configFrom.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(!Settings.Set)
            {
                configFrom.ShowDialog();
            }
        }
        public void clear()
        {
            tbTo.Text = "";
            tbBcc.Text = "";
            tbCc.Text = "";
            tbTitle.Text = "";
            tbMessage.Text = "";
        }
    }
}