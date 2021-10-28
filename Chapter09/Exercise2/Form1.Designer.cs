
namespace Exercise2
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tbOpen = new System.Windows.Forms.Button();
            this.btChange_click = new System.Windows.Forms.Button();
            this.btChangeFile_Clik = new System.Windows.Forms.Button();
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.sfdSaveFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // tbOpen
            // 
            this.tbOpen.Location = new System.Drawing.Point(56, 12);
            this.tbOpen.Name = "tbOpen";
            this.tbOpen.Size = new System.Drawing.Size(97, 63);
            this.tbOpen.TabIndex = 0;
            this.tbOpen.Text = "開く";
            this.tbOpen.UseVisualStyleBackColor = true;
            this.tbOpen.Click += new System.EventHandler(this.tbOpen_Click);
            // 
            // btChange_click
            // 
            this.btChange_click.Location = new System.Drawing.Point(56, 183);
            this.btChange_click.Name = "btChange_click";
            this.btChange_click.Size = new System.Drawing.Size(97, 63);
            this.btChange_click.TabIndex = 1;
            this.btChange_click.Text = "変換";
            this.btChange_click.UseVisualStyleBackColor = true;
            this.btChange_click.Click += new System.EventHandler(this.btChange_click_Click);
            // 
            // btChangeFile_Clik
            // 
            this.btChangeFile_Clik.Location = new System.Drawing.Point(56, 93);
            this.btChangeFile_Clik.Name = "btChangeFile_Clik";
            this.btChangeFile_Clik.Size = new System.Drawing.Size(97, 63);
            this.btChangeFile_Clik.TabIndex = 2;
            this.btChangeFile_Clik.Text = "変換ファイル";
            this.btChangeFile_Clik.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btChangeFile_Clik.UseVisualStyleBackColor = true;
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.FileName = "openFileDialog1";
            // 
            // sfdSaveFile
            // 
            this.sfdSaveFile.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btChangeFile_Clik);
            this.Controls.Add(this.btChange_click);
            this.Controls.Add(this.tbOpen);
            this.Name = "Form1";
            this.Text = "Form1";
            
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tbOpen;
        private System.Windows.Forms.Button btChange_click;
        private System.Windows.Forms.Button btChangeFile_Clik;
        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.OpenFileDialog sfdSaveFile;
    }
}

