namespace RegexGetTextForm
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtSourceFile = new System.Windows.Forms.TextBox();
            this.btnSourceDiag = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTargetFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPattern = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnTargetDiag = new System.Windows.Forms.Button();
            this.txtEncoding = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "源文件";
            // 
            // txtSourceFile
            // 
            this.txtSourceFile.Location = new System.Drawing.Point(87, 10);
            this.txtSourceFile.Name = "txtSourceFile";
            this.txtSourceFile.Size = new System.Drawing.Size(275, 21);
            this.txtSourceFile.TabIndex = 1;
            // 
            // btnSourceDiag
            // 
            this.btnSourceDiag.Location = new System.Drawing.Point(388, 8);
            this.btnSourceDiag.Name = "btnSourceDiag";
            this.btnSourceDiag.Size = new System.Drawing.Size(75, 23);
            this.btnSourceDiag.TabIndex = 2;
            this.btnSourceDiag.Text = "浏览";
            this.btnSourceDiag.UseVisualStyleBackColor = true;
            this.btnSourceDiag.Click += new System.EventHandler(this.btnSourceDiag_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "保存为";
            // 
            // txtTargetFile
            // 
            this.txtTargetFile.Location = new System.Drawing.Point(87, 38);
            this.txtTargetFile.Name = "txtTargetFile";
            this.txtTargetFile.Size = new System.Drawing.Size(275, 21);
            this.txtTargetFile.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "正则表达式";
            // 
            // txtPattern
            // 
            this.txtPattern.Location = new System.Drawing.Point(87, 67);
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.Size = new System.Drawing.Size(275, 21);
            this.txtPattern.TabIndex = 6;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(208, 133);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.FileName = "save";
            // 
            // btnTargetDiag
            // 
            this.btnTargetDiag.Location = new System.Drawing.Point(388, 36);
            this.btnTargetDiag.Name = "btnTargetDiag";
            this.btnTargetDiag.Size = new System.Drawing.Size(75, 23);
            this.btnTargetDiag.TabIndex = 8;
            this.btnTargetDiag.Text = "浏览";
            this.btnTargetDiag.UseVisualStyleBackColor = true;
            this.btnTargetDiag.Click += new System.EventHandler(this.btnTargetDiag_Click);
            // 
            // txtEncoding
            // 
            this.txtEncoding.Location = new System.Drawing.Point(87, 94);
            this.txtEncoding.Name = "txtEncoding";
            this.txtEncoding.Size = new System.Drawing.Size(100, 21);
            this.txtEncoding.TabIndex = 10;
            this.txtEncoding.Text = "utf-8";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "字符集";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 168);
            this.Controls.Add(this.txtEncoding);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTargetDiag);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtPattern);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTargetFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSourceDiag);
            this.Controls.Add(this.txtSourceFile);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "正则获取文件内容";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSourceFile;
        private System.Windows.Forms.Button btnSourceDiag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTargetFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPattern;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnTargetDiag;
        private System.Windows.Forms.TextBox txtEncoding;
        private System.Windows.Forms.Label label4;
    }
}

