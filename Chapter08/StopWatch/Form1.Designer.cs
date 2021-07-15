
namespace StopWatch {
    partial class Form1 {
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbTimerDisp = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Rap = new System.Windows.Forms.Button();
            this.tmDisp = new System.Windows.Forms.Timer(this.components);
            this.lbLapDisp = new System.Windows.Forms.ListBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 421);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(562, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // lbTimerDisp
            // 
            this.lbTimerDisp.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lbTimerDisp.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTimerDisp.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbTimerDisp.Location = new System.Drawing.Point(31, 28);
            this.lbTimerDisp.Name = "lbTimerDisp";
            this.lbTimerDisp.Size = new System.Drawing.Size(237, 76);
            this.lbTimerDisp.TabIndex = 1;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(37, 116);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(104, 53);
            this.Start.TabIndex = 3;
            this.Start.Text = "スタート";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(162, 116);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(104, 53);
            this.Reset.TabIndex = 4;
            this.Reset.Text = "リセット";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(37, 196);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(104, 53);
            this.Stop.TabIndex = 3;
            this.Stop.Text = "ストップ";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Rap
            // 
            this.Rap.Location = new System.Drawing.Point(162, 196);
            this.Rap.Name = "Rap";
            this.Rap.Size = new System.Drawing.Size(104, 53);
            this.Rap.TabIndex = 3;
            this.Rap.Text = "ラップ→";
            this.Rap.UseVisualStyleBackColor = true;
            this.Rap.Click += new System.EventHandler(this.Rap_Click);
            // 
            // lbLapDisp
            // 
            this.lbLapDisp.FormattingEnabled = true;
            this.lbLapDisp.ItemHeight = 12;
            this.lbLapDisp.Location = new System.Drawing.Point(319, 38);
            this.lbLapDisp.Name = "lbLapDisp";
            this.lbLapDisp.Size = new System.Drawing.Size(187, 244);
            this.lbLapDisp.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 443);
            this.Controls.Add(this.lbLapDisp);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Rap);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.lbTimerDisp);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label lbTimerDisp;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Rap;
        private System.Windows.Forms.Timer tmDisp;
        private System.Windows.Forms.ListBox lbLapDisp;
    }
}

