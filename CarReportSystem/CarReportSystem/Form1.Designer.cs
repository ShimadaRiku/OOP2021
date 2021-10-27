
namespace CarReportSystem {
    partial class fmMain {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.cbAuther = new System.Windows.Forms.ComboBox();
            this.cbCarName = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.rbImport = new System.Windows.Forms.RadioButton();
            this.rbSbaru = new System.Windows.Forms.RadioButton();
            this.rbHonda = new System.Windows.Forms.RadioButton();
            this.rbNissan = new System.Windows.Forms.RadioButton();
            this.rbToyota = new System.Windows.Forms.RadioButton();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btPictureOpen = new System.Windows.Forms.Button();
            this.btPictureDelete = new System.Windows.Forms.Button();
            this.btDateAdd = new System.Windows.Forms.Button();
            this.btDateCorrect = new System.Windows.Forms.Button();
            this.btDateDelete = new System.Windows.Forms.Button();
            this.buOpen = new System.Windows.Forms.Button();
            this.buSave = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tbReport = new System.Windows.Forms.TextBox();
            this.btExit = new System.Windows.Forms.Button();
            this.ofdPictureOpen = new System.Windows.Forms.OpenFileDialog();
            this.sfdFileSave = new System.Windows.Forms.OpenFileDialog();
            this.ofdFileOpen = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // cbAuther
            // 
            this.cbAuther.FormattingEnabled = true;
            this.cbAuther.Location = new System.Drawing.Point(125, 64);
            this.cbAuther.Name = "cbAuther";
            this.cbAuther.Size = new System.Drawing.Size(188, 20);
            this.cbAuther.TabIndex = 0;
            // 
            // cbCarName
            // 
            this.cbCarName.FormattingEnabled = true;
            this.cbCarName.Location = new System.Drawing.Point(125, 142);
            this.cbCarName.Name = "cbCarName";
            this.cbCarName.Size = new System.Drawing.Size(188, 20);
            this.cbCarName.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(125, 26);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(245, 19);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbOther);
            this.groupBox1.Controls.Add(this.rbImport);
            this.groupBox1.Controls.Add(this.rbSbaru);
            this.groupBox1.Controls.Add(this.rbHonda);
            this.groupBox1.Controls.Add(this.rbNissan);
            this.groupBox1.Controls.Add(this.rbToyota);
            this.groupBox1.Location = new System.Drawing.Point(125, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 36);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Location = new System.Drawing.Point(290, 20);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(54, 16);
            this.rbOther.TabIndex = 0;
            this.rbOther.TabStop = true;
            this.rbOther.Text = "その他";
            this.rbOther.UseVisualStyleBackColor = true;
            // 
            // rbImport
            // 
            this.rbImport.AutoSize = true;
            this.rbImport.Location = new System.Drawing.Point(225, 20);
            this.rbImport.Name = "rbImport";
            this.rbImport.Size = new System.Drawing.Size(59, 16);
            this.rbImport.TabIndex = 0;
            this.rbImport.TabStop = true;
            this.rbImport.Text = "外国車";
            this.rbImport.UseVisualStyleBackColor = true;
            // 
            // rbSbaru
            // 
            this.rbSbaru.AutoSize = true;
            this.rbSbaru.Location = new System.Drawing.Point(167, 20);
            this.rbSbaru.Name = "rbSbaru";
            this.rbSbaru.Size = new System.Drawing.Size(52, 16);
            this.rbSbaru.TabIndex = 0;
            this.rbSbaru.TabStop = true;
            this.rbSbaru.Text = "スバル";
            this.rbSbaru.UseVisualStyleBackColor = true;
            // 
            // rbHonda
            // 
            this.rbHonda.AutoSize = true;
            this.rbHonda.Location = new System.Drawing.Point(112, 20);
            this.rbHonda.Name = "rbHonda";
            this.rbHonda.Size = new System.Drawing.Size(51, 16);
            this.rbHonda.TabIndex = 0;
            this.rbHonda.TabStop = true;
            this.rbHonda.Text = "ホンダ";
            this.rbHonda.UseVisualStyleBackColor = true;
            // 
            // rbNissan
            // 
            this.rbNissan.AutoSize = true;
            this.rbNissan.Location = new System.Drawing.Point(59, 18);
            this.rbNissan.Name = "rbNissan";
            this.rbNissan.Size = new System.Drawing.Size(47, 16);
            this.rbNissan.TabIndex = 0;
            this.rbNissan.TabStop = true;
            this.rbNissan.Text = "日産";
            this.rbNissan.UseVisualStyleBackColor = true;
            // 
            // rbToyota
            // 
            this.rbToyota.AutoSize = true;
            this.rbToyota.Location = new System.Drawing.Point(6, 18);
            this.rbToyota.Name = "rbToyota";
            this.rbToyota.Size = new System.Drawing.Size(47, 16);
            this.rbToyota.TabIndex = 0;
            this.rbToyota.TabStop = true;
            this.rbToyota.Text = "トヨタ";
            this.rbToyota.UseVisualStyleBackColor = true;
            // 
            // pbPicture
            // 
            this.pbPicture.Location = new System.Drawing.Point(529, 44);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(285, 226);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPicture.TabIndex = 4;
            this.pbPicture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "日付：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "記録者：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "メーカー：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "車名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "レポート：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(517, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "画像：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "記事一覧：";
            // 
            // btPictureOpen
            // 
            this.btPictureOpen.Location = new System.Drawing.Point(598, 12);
            this.btPictureOpen.Name = "btPictureOpen";
            this.btPictureOpen.Size = new System.Drawing.Size(88, 24);
            this.btPictureOpen.TabIndex = 8;
            this.btPictureOpen.Text = "開く";
            this.btPictureOpen.UseVisualStyleBackColor = true;
            // 
            // btPictureDelete
            // 
            this.btPictureDelete.Location = new System.Drawing.Point(703, 12);
            this.btPictureDelete.Name = "btPictureDelete";
            this.btPictureDelete.Size = new System.Drawing.Size(88, 24);
            this.btPictureDelete.TabIndex = 8;
            this.btPictureDelete.Text = "削除";
            this.btPictureDelete.UseVisualStyleBackColor = true;
            // 
            // btDateAdd
            // 
            this.btDateAdd.Location = new System.Drawing.Point(529, 287);
            this.btDateAdd.Name = "btDateAdd";
            this.btDateAdd.Size = new System.Drawing.Size(78, 46);
            this.btDateAdd.TabIndex = 8;
            this.btDateAdd.Text = "追加";
            this.btDateAdd.UseVisualStyleBackColor = true;
            // 
            // btDateCorrect
            // 
            this.btDateCorrect.Location = new System.Drawing.Point(632, 287);
            this.btDateCorrect.Name = "btDateCorrect";
            this.btDateCorrect.Size = new System.Drawing.Size(75, 46);
            this.btDateCorrect.TabIndex = 8;
            this.btDateCorrect.Text = "修正";
            this.btDateCorrect.UseVisualStyleBackColor = true;
            // 
            // btDateDelete
            // 
            this.btDateDelete.Location = new System.Drawing.Point(728, 287);
            this.btDateDelete.Name = "btDateDelete";
            this.btDateDelete.Size = new System.Drawing.Size(74, 46);
            this.btDateDelete.TabIndex = 8;
            this.btDateDelete.Text = "削除";
            this.btDateDelete.UseVisualStyleBackColor = true;
            this.btDateDelete.Click += new System.EventHandler(this.btDateDelete_Click_1);
            // 
            // buOpen
            // 
            this.buOpen.Location = new System.Drawing.Point(45, 365);
            this.buOpen.Name = "buOpen";
            this.buOpen.Size = new System.Drawing.Size(59, 28);
            this.buOpen.TabIndex = 9;
            this.buOpen.Text = "開く";
            this.buOpen.UseVisualStyleBackColor = true;
            // 
            // buSave
            // 
            this.buSave.Location = new System.Drawing.Point(45, 413);
            this.buSave.Name = "buSave";
            this.buSave.Size = new System.Drawing.Size(58, 32);
            this.buSave.TabIndex = 9;
            this.buSave.Text = "保存";
            this.buSave.UseVisualStyleBackColor = true;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(125, 339);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 21;
            this.dgv.Size = new System.Drawing.Size(666, 201);
            this.dgv.TabIndex = 10;
            // 
            // tbReport
            // 
            this.tbReport.Location = new System.Drawing.Point(125, 186);
            this.tbReport.Multiline = true;
            this.tbReport.Name = "tbReport";
            this.tbReport.Size = new System.Drawing.Size(344, 127);
            this.tbReport.TabIndex = 11;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(45, 460);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(58, 32);
            this.btExit.TabIndex = 9;
            this.btExit.Text = "終了";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // ofdPictureOpen
            // 
            this.ofdPictureOpen.FileName = "openFileDialog1";
            // 
            // sfdFileSave
            // 
            this.sfdFileSave.FileName = "openFileDialog1";
            // 
            // ofdFileOpen
            // 
            this.ofdFileOpen.FileName = "openFileDialog1";
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 654);
            this.Controls.Add(this.tbReport);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.buSave);
            this.Controls.Add(this.buOpen);
            this.Controls.Add(this.btDateDelete);
            this.Controls.Add(this.btPictureDelete);
            this.Controls.Add(this.btDateAdd);
            this.Controls.Add(this.btDateCorrect);
            this.Controls.Add(this.btPictureOpen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbPicture);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbCarName);
            this.Controls.Add(this.cbAuther);
            this.Name = "fmMain";
            this.Text = "試乗レポート管理システム";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAuther;
        private System.Windows.Forms.ComboBox cbCarName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSbaru;
        private System.Windows.Forms.RadioButton rbHonda;
        private System.Windows.Forms.RadioButton rbNissan;
        private System.Windows.Forms.RadioButton rbToyota;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.RadioButton rbImport;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btPictureOpen;
        private System.Windows.Forms.Button btPictureDelete;
        private System.Windows.Forms.Button btDateAdd;
        private System.Windows.Forms.Button btDateCorrect;
        private System.Windows.Forms.Button btDateDelete;
        private System.Windows.Forms.Button buOpen;
        private System.Windows.Forms.Button buSave;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox tbReport;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.OpenFileDialog ofdPictureOpen;
        private System.Windows.Forms.OpenFileDialog sfdFileSave;
        private System.Windows.Forms.OpenFileDialog ofdFileOpen;
    }
}

