
namespace Excercise3 {
    partial class textBox {
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
            this.label1 = new System.Windows.Forms.Label();
            this.Spacecount = new System.Windows.Forms.TextBox();
            this.Button5_3_1 = new System.Windows.Forms.Button();
            this.Button5_3_2 = new System.Windows.Forms.Button();
            this.textBoxWordChange = new System.Windows.Forms.TextBox();
            this.inputStrText = new System.Windows.Forms.TextBox();
            this.Button5_3_3 = new System.Windows.Forms.Button();
            this.WordCount = new System.Windows.Forms.TextBox();
            this.four = new System.Windows.Forms.TextBox();
            this.Button5_3_4 = new System.Windows.Forms.Button();
            this.Button5_3_5 = new System.Windows.Forms.Button();
            this.copy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputStrData = new System.Windows.Forms.TextBox();
            this.Button5_4 = new System.Windows.Forms.Button();
            this.outStrDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "問題5.3";
            // 
            // Spacecount
            // 
            this.Spacecount.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Spacecount.Location = new System.Drawing.Point(173, 112);
            this.Spacecount.Name = "Spacecount";
            this.Spacecount.Size = new System.Drawing.Size(208, 31);
            this.Spacecount.TabIndex = 1;
            // 
            // Button5_3_1
            // 
            this.Button5_3_1.Location = new System.Drawing.Point(30, 93);
            this.Button5_3_1.Name = "Button5_3_1";
            this.Button5_3_1.Size = new System.Drawing.Size(106, 50);
            this.Button5_3_1.TabIndex = 2;
            this.Button5_3_1.Text = "空白をカウント";
            this.Button5_3_1.UseVisualStyleBackColor = true;
            this.Button5_3_1.Click += new System.EventHandler(this.Button5_3_1_Click);
            // 
            // Button5_3_2
            // 
            this.Button5_3_2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button5_3_2.Location = new System.Drawing.Point(30, 162);
            this.Button5_3_2.Name = "Button5_3_2";
            this.Button5_3_2.Size = new System.Drawing.Size(106, 49);
            this.Button5_3_2.TabIndex = 3;
            this.Button5_3_2.Text = "big→small";
            this.Button5_3_2.UseVisualStyleBackColor = true;
            this.Button5_3_2.Click += new System.EventHandler(this.Button5_3_2_Click);
            // 
            // textBoxWordChange
            // 
            this.textBoxWordChange.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxWordChange.Location = new System.Drawing.Point(173, 174);
            this.textBoxWordChange.Name = "textBoxWordChange";
            this.textBoxWordChange.Size = new System.Drawing.Size(601, 26);
            this.textBoxWordChange.TabIndex = 4;
            // 
            // inputStrText
            // 
            this.inputStrText.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.inputStrText.Location = new System.Drawing.Point(12, 58);
            this.inputStrText.Name = "inputStrText";
            this.inputStrText.Size = new System.Drawing.Size(713, 28);
            this.inputStrText.TabIndex = 5;
            // 
            // Button5_3_3
            // 
            this.Button5_3_3.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button5_3_3.Location = new System.Drawing.Point(17, 234);
            this.Button5_3_3.Name = "Button5_3_3";
            this.Button5_3_3.Size = new System.Drawing.Size(134, 45);
            this.Button5_3_3.TabIndex = 6;
            this.Button5_3_3.Text = "word count";
            this.Button5_3_3.UseVisualStyleBackColor = true;
            this.Button5_3_3.Click += new System.EventHandler(this.Button5_3_3_Click);
            // 
            // WordCount
            // 
            this.WordCount.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.WordCount.Location = new System.Drawing.Point(173, 245);
            this.WordCount.Name = "WordCount";
            this.WordCount.Size = new System.Drawing.Size(500, 34);
            this.WordCount.TabIndex = 7;
            // 
            // four
            // 
            this.four.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.four.Location = new System.Drawing.Point(173, 316);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(500, 34);
            this.four.TabIndex = 7;
            // 
            // Button5_3_4
            // 
            this.Button5_3_4.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button5_3_4.Location = new System.Drawing.Point(17, 305);
            this.Button5_3_4.Name = "Button5_3_4";
            this.Button5_3_4.Size = new System.Drawing.Size(134, 45);
            this.Button5_3_4.TabIndex = 6;
            this.Button5_3_4.Text = "4文字以下";
            this.Button5_3_4.UseVisualStyleBackColor = true;
            this.Button5_3_4.Click += new System.EventHandler(this.Button5_3_4_Click);
            // 
            // Button5_3_5
            // 
            this.Button5_3_5.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button5_3_5.Location = new System.Drawing.Point(17, 375);
            this.Button5_3_5.Name = "Button5_3_5";
            this.Button5_3_5.Size = new System.Drawing.Size(134, 45);
            this.Button5_3_5.TabIndex = 6;
            this.Button5_3_5.Text = "StringBuilder";
            this.Button5_3_5.UseVisualStyleBackColor = true;
            this.Button5_3_5.Click += new System.EventHandler(this.Button5_3_5_Click);
            // 
            // copy
            // 
            this.copy.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.copy.Location = new System.Drawing.Point(173, 386);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(500, 34);
            this.copy.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(12, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "問題5.4";
            // 
            // inputStrData
            // 
            this.inputStrData.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.inputStrData.Location = new System.Drawing.Point(173, 475);
            this.inputStrData.Name = "inputStrData";
            this.inputStrData.Size = new System.Drawing.Size(656, 31);
            this.inputStrData.TabIndex = 8;
            // 
            // Button5_4
            // 
            this.Button5_4.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button5_4.Location = new System.Drawing.Point(17, 477);
            this.Button5_4.Name = "Button5_4";
            this.Button5_4.Size = new System.Drawing.Size(134, 37);
            this.Button5_4.TabIndex = 9;
            this.Button5_4.Text = "問題5.4";
            this.Button5_4.UseVisualStyleBackColor = true;
            this.Button5_4.Click += new System.EventHandler(this.Button5_4_Click);
            // 
            // outStrDate
            // 
            this.outStrDate.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.outStrDate.Location = new System.Drawing.Point(171, 532);
            this.outStrDate.Name = "outStrDate";
            this.outStrDate.Size = new System.Drawing.Size(657, 42);
            this.outStrDate.TabIndex = 10;
            // 
            // textBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 650);
            this.Controls.Add(this.outStrDate);
            this.Controls.Add(this.Button5_4);
            this.Controls.Add(this.inputStrData);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.four);
            this.Controls.Add(this.Button5_3_5);
            this.Controls.Add(this.Button5_3_4);
            this.Controls.Add(this.WordCount);
            this.Controls.Add(this.Button5_3_3);
            this.Controls.Add(this.inputStrText);
            this.Controls.Add(this.textBoxWordChange);
            this.Controls.Add(this.Button5_3_2);
            this.Controls.Add(this.Button5_3_1);
            this.Controls.Add(this.Spacecount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "textBox";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Spacecount;
        private System.Windows.Forms.Button Button5_3_1;
        public System.Windows.Forms.Button Button5_3_2;
        private System.Windows.Forms.TextBox textBoxWordChange;
        private System.Windows.Forms.TextBox inputStrText;
        private System.Windows.Forms.Button Button5_3_3;
        private System.Windows.Forms.TextBox WordCount;
        private System.Windows.Forms.TextBox four;
        private System.Windows.Forms.Button Button5_3_4;
        private System.Windows.Forms.Button Button5_3_5;
        private System.Windows.Forms.TextBox copy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputStrData;
        private System.Windows.Forms.Button Button5_4;
        private System.Windows.Forms.TextBox outStrDate;
    }
}

