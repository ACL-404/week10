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
            this.list = new System.Windows.Forms.ListBox();
            this.lastbt = new System.Windows.Forms.Button();
            this.nestbt = new System.Windows.Forms.Button();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.comboBoxStyle = new System.Windows.Forms.ComboBox();
            this.comboBoxFont = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // open
            // 
            this.open.BackColor = System.Drawing.SystemColors.Info;
            this.open.Location = new System.Drawing.Point(377, 12);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(111, 39);
            this.open.TabIndex = 0;
            this.open.Text = "開啟";
            this.open.UseVisualStyleBackColor = false;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.SystemColors.Info;
            this.save.Location = new System.Drawing.Point(494, 12);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(111, 39);
            this.save.TabIndex = 1;
            this.save.Text = "存檔";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // textwindow01
            // 
            this.textwindow01.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textwindow01.Location = new System.Drawing.Point(26, 41);
            this.textwindow01.Name = "textwindow01";
            this.textwindow01.Size = new System.Drawing.Size(345, 386);
            this.textwindow01.TabIndex = 2;
            this.textwindow01.Text = "";
            this.textwindow01.TextChanged += new System.EventHandler(this.textwindow01_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // list
            // 
            this.list.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.list.FormattingEnabled = true;
            this.list.ItemHeight = 15;
            this.list.Location = new System.Drawing.Point(377, 108);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(228, 319);
            this.list.TabIndex = 6;
            // 
            // lastbt
            // 
            this.lastbt.BackColor = System.Drawing.SystemColors.Info;
            this.lastbt.Location = new System.Drawing.Point(377, 57);
            this.lastbt.Name = "lastbt";
            this.lastbt.Size = new System.Drawing.Size(111, 39);
            this.lastbt.TabIndex = 7;
            this.lastbt.Text = "上一步";
            this.lastbt.UseVisualStyleBackColor = false;
            this.lastbt.Click += new System.EventHandler(this.lastbt_Click);
            // 
            // nestbt
            // 
            this.nestbt.BackColor = System.Drawing.SystemColors.Info;
            this.nestbt.Location = new System.Drawing.Point(494, 57);
            this.nestbt.Name = "nestbt";
            this.nestbt.Size = new System.Drawing.Size(111, 39);
            this.nestbt.TabIndex = 8;
            this.nestbt.Text = "下一步";
            this.nestbt.UseVisualStyleBackColor = false;
            this.nestbt.Click += new System.EventHandler(this.nestbt_Click);
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Location = new System.Drawing.Point(143, 12);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(111, 23);
            this.comboBoxSize.TabIndex = 10;
            this.comboBoxSize.Text = "字體大小";
            // 
            // comboBoxStyle
            // 
            this.comboBoxStyle.FormattingEnabled = true;
            this.comboBoxStyle.Location = new System.Drawing.Point(260, 12);
            this.comboBoxStyle.Name = "comboBoxStyle";
            this.comboBoxStyle.Size = new System.Drawing.Size(111, 23);
            this.comboBoxStyle.TabIndex = 11;
            this.comboBoxStyle.Text = "字體樣式";
            this.comboBoxStyle.SelectedIndexChanged += new System.EventHandler(this.comboBoxStyle_SelectedIndexChanged);
            // 
            // comboBoxFont
            // 
            this.comboBoxFont.FormattingEnabled = true;
            this.comboBoxFont.Location = new System.Drawing.Point(26, 12);
            this.comboBoxFont.Name = "comboBoxFont";
            this.comboBoxFont.Size = new System.Drawing.Size(111, 23);
            this.comboBoxFont.TabIndex = 12;
            this.comboBoxFont.Text = "字型選單";
            // 
            // window1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(630, 439);
            this.Controls.Add(this.comboBoxFont);
            this.Controls.Add(this.comboBoxStyle);
            this.Controls.Add(this.comboBoxSize);
            this.Controls.Add(this.nestbt);
            this.Controls.Add(this.lastbt);
            this.Controls.Add(this.list);
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
        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.Button lastbt;
        private System.Windows.Forms.Button nestbt;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.ComboBox comboBoxStyle;
        private System.Windows.Forms.ComboBox comboBoxFont;
    }
}

