namespace week10
{
    partial class window1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.open = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.textwindow01 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // open
            // 
            this.open.BackColor = System.Drawing.SystemColors.Info;
            this.open.Location = new System.Drawing.Point(26, 38);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(111, 63);
            this.open.TabIndex = 0;
            this.open.Text = "開啟";
            this.open.UseVisualStyleBackColor = false;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.SystemColors.Info;
            this.save.Location = new System.Drawing.Point(143, 38);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(111, 63);
            this.save.TabIndex = 1;
            this.save.Text = "存檔";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // textwindow01
            // 
            this.textwindow01.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textwindow01.Location = new System.Drawing.Point(26, 107);
            this.textwindow01.Name = "textwindow01";
            this.textwindow01.Size = new System.Drawing.Size(467, 320);
            this.textwindow01.TabIndex = 2;
            this.textwindow01.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // window1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(711, 439);
            this.Controls.Add(this.textwindow01);
            this.Controls.Add(this.save);
            this.Controls.Add(this.open);
            this.Name = "window1";
            this.Text = "mainwindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.RichTextBox textwindow01;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

