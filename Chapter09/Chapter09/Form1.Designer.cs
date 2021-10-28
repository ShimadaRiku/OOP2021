
namespace Chapter09
{
    partial class ofdOpenFile
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
            this.btOpen = new System.Windows.Forms.Button();
            this.tbKeyWord = new System.Windows.Forms.TextBox();
            this.keyWord = new System.Windows.Forms.Label();
            this.tbReadAllLines = new System.Windows.Forms.Button();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.tbReadLines = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(31, 35);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(172, 40);
            this.btOpen.TabIndex = 0;
            this.btOpen.Text = "開く";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // tbKeyWord
            // 
            this.tbKeyWord.Location = new System.Drawing.Point(230, 56);
            this.tbKeyWord.Name = "tbKeyWord";
            this.tbKeyWord.Size = new System.Drawing.Size(123, 19);
            this.tbKeyWord.TabIndex = 1;
            // 
            // keyWord
            // 
            this.keyWord.AutoSize = true;
            this.keyWord.Location = new System.Drawing.Point(228, 35);
            this.keyWord.Name = "keyWord";
            this.keyWord.Size = new System.Drawing.Size(53, 12);
            this.keyWord.TabIndex = 2;
            this.keyWord.Text = "キーワード";
            // 
            // tbReadAllLines
            // 
            this.tbReadAllLines.Location = new System.Drawing.Point(396, 34);
            this.tbReadAllLines.Name = "tbReadAllLines";
            this.tbReadAllLines.Size = new System.Drawing.Size(141, 41);
            this.tbReadAllLines.TabIndex = 3;
            this.tbReadAllLines.Text = "ReadAllLines";
            this.tbReadAllLines.UseVisualStyleBackColor = true;
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(31, 122);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(552, 231);
            this.tbOutput.TabIndex = 4;
            // 
            // tbReadLines
            // 
            this.tbReadLines.Location = new System.Drawing.Point(561, 35);
            this.tbReadLines.Name = "tbReadLines";
            this.tbReadLines.Size = new System.Drawing.Size(119, 40);
            this.tbReadLines.TabIndex = 5;
            this.tbReadLines.Text = "ReadLines";
            this.tbReadLines.UseVisualStyleBackColor = true;
            // 
            // ofdOpenFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbReadLines);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.tbReadAllLines);
            this.Controls.Add(this.keyWord);
            this.Controls.Add(this.tbKeyWord);
            this.Controls.Add(this.btOpen);
            this.Name = "ofdOpenFile";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.TextBox tbKeyWord;
        private System.Windows.Forms.Label keyWord;
        private System.Windows.Forms.Button tbReadAllLines;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button tbReadLines;
    }
}

