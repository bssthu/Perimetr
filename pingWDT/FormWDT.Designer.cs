namespace pingWDT
{
    partial class FormWDT
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWDT));
            this.labelIP = new System.Windows.Forms.Label();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.labelPeriod = new System.Windows.Forms.Label();
            this.textBoxPeroid = new System.Windows.Forms.TextBox();
            this.labelPeriodUnit = new System.Windows.Forms.Label();
            this.textBoxLostCount = new System.Windows.Forms.TextBox();
            this.labelLost = new System.Windows.Forms.Label();
            this.labelCmd = new System.Windows.Forms.Label();
            this.textBoxCmd = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonApply = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelLostCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonTerminate = new System.Windows.Forms.Button();
            this.buttonHide = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Location = new System.Drawing.Point(250, 15);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(43, 17);
            this.labelIP.TabIndex = 0;
            this.labelIP.Text = "目标IP";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIP.Location = new System.Drawing.Point(299, 12);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(95, 23);
            this.textBoxIP.TabIndex = 1;
            this.textBoxIP.Text = "166.111.8.28";
            // 
            // labelPeriod
            // 
            this.labelPeriod.AutoSize = true;
            this.labelPeriod.Location = new System.Drawing.Point(12, 15);
            this.labelPeriod.Name = "labelPeriod";
            this.labelPeriod.Size = new System.Drawing.Size(56, 17);
            this.labelPeriod.TabIndex = 2;
            this.labelPeriod.Text = "检查周期";
            // 
            // textBoxPeroid
            // 
            this.textBoxPeroid.Location = new System.Drawing.Point(74, 12);
            this.textBoxPeroid.Name = "textBoxPeroid";
            this.textBoxPeroid.Size = new System.Drawing.Size(38, 23);
            this.textBoxPeroid.TabIndex = 1;
            this.textBoxPeroid.Text = "40";
            // 
            // labelPeriodUnit
            // 
            this.labelPeriodUnit.AutoSize = true;
            this.labelPeriodUnit.Location = new System.Drawing.Point(118, 15);
            this.labelPeriodUnit.Name = "labelPeriodUnit";
            this.labelPeriodUnit.Size = new System.Drawing.Size(20, 17);
            this.labelPeriodUnit.TabIndex = 2;
            this.labelPeriodUnit.Text = "秒";
            // 
            // textBoxLostCount
            // 
            this.textBoxLostCount.Location = new System.Drawing.Point(206, 12);
            this.textBoxLostCount.Name = "textBoxLostCount";
            this.textBoxLostCount.Size = new System.Drawing.Size(38, 23);
            this.textBoxLostCount.TabIndex = 1;
            this.textBoxLostCount.Text = "5";
            // 
            // labelLost
            // 
            this.labelLost.AutoSize = true;
            this.labelLost.Location = new System.Drawing.Point(144, 15);
            this.labelLost.Name = "labelLost";
            this.labelLost.Size = new System.Drawing.Size(56, 17);
            this.labelLost.TabIndex = 2;
            this.labelLost.Text = "失联次数";
            // 
            // labelCmd
            // 
            this.labelCmd.AutoSize = true;
            this.labelCmd.Location = new System.Drawing.Point(12, 44);
            this.labelCmd.Name = "labelCmd";
            this.labelCmd.Size = new System.Drawing.Size(56, 17);
            this.labelCmd.TabIndex = 2;
            this.labelCmd.Text = "执行命令";
            // 
            // textBoxCmd
            // 
            this.textBoxCmd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCmd.Location = new System.Drawing.Point(74, 41);
            this.textBoxCmd.Name = "textBoxCmd";
            this.textBoxCmd.Size = new System.Drawing.Size(320, 23);
            this.textBoxCmd.TabIndex = 1;
            this.textBoxCmd.Text = "shutdown /s /t 30";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(74, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(320, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "shutdown /a";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "取消命令";
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonApply.Enabled = false;
            this.buttonApply.Location = new System.Drawing.Point(12, 99);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(70, 23);
            this.buttonApply.TabIndex = 3;
            this.buttonApply.Text = "应用(&A)";
            this.buttonApply.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelLostCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 129);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(406, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelLostCount
            // 
            this.toolStripStatusLabelLostCount.Name = "toolStripStatusLabelLostCount";
            this.toolStripStatusLabelLostCount.Size = new System.Drawing.Size(92, 17);
            this.toolStripStatusLabelLostCount.Text = "当前失联次数：";
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonReset.Location = new System.Drawing.Point(168, 99);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(70, 23);
            this.buttonReset.TabIndex = 3;
            this.buttonReset.Text = "重置(&R)";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // buttonTerminate
            // 
            this.buttonTerminate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonTerminate.Location = new System.Drawing.Point(246, 99);
            this.buttonTerminate.Name = "buttonTerminate";
            this.buttonTerminate.Size = new System.Drawing.Size(70, 23);
            this.buttonTerminate.TabIndex = 3;
            this.buttonTerminate.Text = "终止(&T)";
            this.buttonTerminate.UseVisualStyleBackColor = true;
            // 
            // buttonHide
            // 
            this.buttonHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonHide.Location = new System.Drawing.Point(90, 99);
            this.buttonHide.Name = "buttonHide";
            this.buttonHide.Size = new System.Drawing.Size(70, 23);
            this.buttonHide.TabIndex = 3;
            this.buttonHide.Text = "隐藏(&H)";
            this.buttonHide.UseVisualStyleBackColor = true;
            // 
            // buttonAbout
            // 
            this.buttonAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAbout.Location = new System.Drawing.Point(324, 99);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(70, 23);
            this.buttonAbout.TabIndex = 3;
            this.buttonAbout.Text = "关于";
            this.buttonAbout.UseVisualStyleBackColor = true;
            // 
            // FormWDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 151);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonHide);
            this.Controls.Add(this.buttonTerminate);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.labelPeriodUnit);
            this.Controls.Add(this.labelLost);
            this.Controls.Add(this.textBoxLostCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCmd);
            this.Controls.Add(this.labelPeriod);
            this.Controls.Add(this.textBoxPeroid);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxCmd);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.labelIP);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(422, 2);
            this.Name = "FormWDT";
            this.Text = "pingWDT";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Label labelPeriod;
        private System.Windows.Forms.TextBox textBoxPeroid;
        private System.Windows.Forms.Label labelPeriodUnit;
        private System.Windows.Forms.TextBox textBoxLostCount;
        private System.Windows.Forms.Label labelLost;
        private System.Windows.Forms.Label labelCmd;
        private System.Windows.Forms.TextBox textBoxCmd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLostCount;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonTerminate;
        private System.Windows.Forms.Button buttonHide;
        private System.Windows.Forms.Button buttonAbout;
    }
}

