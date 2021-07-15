using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class fmMain : Form {
        BindingList<CarReport> listCarReport = new BindingList<CarReport>();
        public fmMain() {
            InitializeComponent();
            dgv.DataSource = listCarReport;
        }

        private void btExit_Click(object sender, EventArgs e) {
            Application.Exit();//アプリケーションの終了
        }

        private void pbPictureOpen_Click(object sender, EventArgs e) {
            if (ofdPictureOpen.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdPictureOpen.FileName);
            }
        }

        private void pbPictureDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        private void btDataAdd_Click(object sender, EventArgs e) {
            if (cbAuther.Text == "" || cbCarName.Text == "") {
                MessageBox.Show("入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CarReport carReport = new CarReport {
                Date = dtpDate.Value,
                Auther = cbAuther.Text,
                Maker = selectedGroup(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                Picture = pbPicture.Image
            };
            listCarReport.Add(carReport);

            setCbAuther(cbAuther.Text);
        }

        private CarReport.MakerGroup selectedGroup() {
            foreach (var rb in gbMaker.Controls) {
                if (((RadioButton)rb).Checked) {
                    return (CarReport.MakerGroup)int.Parse(((String)((RadioButton)rb).Tag));
                }
            }
            return CarReport.MakerGroup.その他;
        }
        private void setCbAuther(string auther) {
            if (!cbAuther.Items.Contains(auther)) {
                cbAuther.Items.Add(auther);
            }
        }
        private void setCbCarName(string auther) {

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e) {
            //選択された行のデータを取得
            CarReport selectedCar = listCarReport[e.RowIndex];

            //取得したデータ項目を各コントロールへ設定
            dtpDate.Value = selectedCar.Date;
            cbAuther.Text = selectedCar.Auther;
            setMakerRadioButton(selectedCar.Maker);
            cbCarName.Text = selectedCar.CarName;
            tbReport.Text = selectedCar.Report;
            pbPicture.Image = selectedCar.Picture;
        }

        private void btDateDelete_Click(object sender, EventArgs e) {
            listCarReport.RemoveAt(d)
        }

        private void groupBox1_Enter(object sender, EventArgs e) {

        }
    }
}
