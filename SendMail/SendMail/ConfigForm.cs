using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SendMail
{
    public partial class ConfigForm : Form
    {
        private Settings settings = Settings.getInstance();

        //private Settings setting = new Settings();

        public ConfigForm()
        {
            InitializeComponent();
        }
        private void tbDefault_Click(object sender, EventArgs e)
        {
            
            tbHost.Text = settings.sHost();     //ホスト名
            tbPort.Text = settings.sPort();     //ポート番号
            tbUserName.Text = settings.sMailAddr();//ユーザー名
            tbPass.Text = settings.sPass();     //パスワード
            cbSsl.Checked = settings.bSsl();    //SSL
            tbSender.Text = settings.sMailAddr();//送信元
        }
        //OKボタン
        private void btOk_Click(object sender, EventArgs e)
        {
            //settings.setSendConfig(tbHost.Text, int.Parse(tbPort.Text),
            //                   tbUserName.Text, tbPass.Text, cbSsl.Checked);


            btApply_Click(sender, e);   //適用ボタンの処理を呼び出し
            this.Close();
        }
        //送信データの登録
        private void SettingRegist()
        {
            settings.Host = tbHost.Text;
            settings.Port = int.Parse(tbPort.Text);
            settings.MailAddr = tbUserName.Text;
            settings.Pass = tbPass.Text;
            settings.Ssl = cbSsl.Checked;

            //ファイルへ書き出し(シリアル化)
            var xws = new XmlWriterSettings
            {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = " ",
            };

            using (var writer = XmlWriter.Create("mailsetting.xml", xws))
            {
                var serializer = new DataContractSerializer(settings.GetType());
                serializer.WriteObject(writer, settings);
            }

        }
        private void btApply_Click(object sender, EventArgs e)
        {
            settings.setSendConfig(tbHost.Text, int.Parse(tbPort.Text),
                                tbUserName.Text, tbPass.Text, cbSsl.Checked);
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            tbHost.Text = settings.Host;
            tbPort.Text = settings.Port.ToString();
            tbUserName.Text = settings.MailAddr;
            tbPass.Text = settings.Pass;
            cbSsl.Checked = settings.Ssl;
            tbSender.Text = settings.MailAddr;

        }
    }
}
