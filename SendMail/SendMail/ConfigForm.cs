using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        
        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbDefault_Click(object sender, EventArgs e)
        {
            
            tbHost.Text = settings.sHost();     //ホスト名
            tbPort.Text = settings.sPort();     //ポート番号
            tbUserName.Text = settings.sMailAddr();//ユーザー名
            tbPass.Text = settings.sPass();     //パスワード
            cbSsl.Checked = settings.bSsl();    //SSL
            tbSender.Text = settings.sMailAddr();//添いう新先
        }
        //OKボタン
        private void btOk_Click(object sender, EventArgs e)
        {
            SettingRegist();
            this.Close();
        }

        private void SettingRegist()
        {
            settings.Host = tbHost.Text;
            settings.Port = int.Parse(tbPort.Text);
            settings.MailAddr = tbUserName.Text;
            settings.Pass = tbPass.Text;
            settings.Ssl = cbSsl.Checked;
        }

        private void btApply_Click(object sender, EventArgs e)
        {
            SettingRegist();
        }

        
    }
}
