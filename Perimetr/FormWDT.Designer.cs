namespace Perimetr
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
            this.textBoxMaxCount = new System.Windows.Forms.TextBox();
            this.labelLost = new System.Windows.Forms.Label();
            this.labelCmd = new System.Windows.Forms.Label();
            this.textBoxCmd = new System.Windows.Forms.TextBox();
            this.textBoxCmdAbort = new System.Windows.Forms.TextBox();
            this.labelCmdAbort = new System.Windows.Forms.Label();
            this.buttonApply = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelLostCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelLostCountValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonDefault = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
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
            this.textBoxIP.TextChanged += new System.EventHandler(this.textBoxs_TextChanged);
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
            this.textBoxPeroid.TextChanged += new System.EventHandler(this.textBoxs_TextChanged);
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
            // textBoxMaxCount
            // 
            this.textBoxMaxCount.Location = new System.Drawing.Point(206, 12);
            this.textBoxMaxCount.Name = "textBoxMaxCount";
            this.textBoxMaxCount.Size = new System.Drawing.Size(38, 23);
            this.textBoxMaxCount.TabIndex = 1;
            this.textBoxMaxCount.Text = "5";
            this.textBoxMaxCount.TextChanged += new System.EventHandler(this.textBoxs_TextChanged);
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
            this.textBoxCmd.TextChanged += new System.EventHandler(this.textBoxs_TextChanged);
            // 
            // textBoxCmdAbort
            // 
            this.textBoxCmdAbort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCmdAbort.Location = new System.Drawing.Point(74, 70);
            this.textBoxCmdAbort.Name = "textBoxCmdAbort";
            this.textBoxCmdAbort.Size = new System.Drawing.Size(320, 23);
            this.textBoxCmdAbort.TabIndex = 1;
            this.textBoxCmdAbort.Text = "shutdown /a";
            this.textBoxCmdAbort.TextChanged += new System.EventHandler(this.textBoxs_TextChanged);
            // 
            // labelCmdAbort
            // 
            this.labelCmdAbort.AutoSize = true;
            this.labelCmdAbort.Location = new System.Drawing.Point(12, 73);
            this.labelCmdAbort.Name = "labelCmdAbort";
            this.labelCmdAbort.Size = new System.Drawing.Size(56, 17);
            this.labelCmdAbort.TabIndex = 2;
            this.labelCmdAbort.Text = "取消命令";
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
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelLostCount,
            this.toolStripStatusLabelLostCountValue});
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
            // toolStripStatusLabelLostCountValue
            // 
            this.toolStripStatusLabelLostCountValue.Name = "toolStripStatusLabelLostCountValue";
            this.toolStripStatusLabelLostCountValue.Size = new System.Drawing.Size(15, 17);
            this.toolStripStatusLabelLostCountValue.Text = "0";
            // 
            // buttonDefault
            // 
            this.buttonDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDefault.Location = new System.Drawing.Point(168, 99);
            this.buttonDefault.Name = "buttonDefault";
            this.buttonDefault.Size = new System.Drawing.Size(70, 23);
            this.buttonDefault.TabIndex = 3;
            this.buttonDefault.Text = "默认(&D)";
            this.buttonDefault.UseVisualStyleBackColor = true;
            this.buttonDefault.Click += new System.EventHandler(this.buttonDefault_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonReset.Location = new System.Drawing.Point(246, 99);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(70, 23);
            this.buttonReset.TabIndex = 3;
            this.buttonReset.Text = "重置(&R)";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
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
            this.buttonHide.Click += new System.EventHandler(this.buttonHide_Click);
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
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // FormWDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 151);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonHide);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonDefault);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.labelPeriodUnit);
            this.Controls.Add(this.labelLost);
            this.Controls.Add(this.textBoxMaxCount);
            this.Controls.Add(this.labelCmdAbort);
            this.Controls.Add(this.labelCmd);
            this.Controls.Add(this.labelPeriod);
            this.Controls.Add(this.textBoxPeroid);
            this.Controls.Add(this.textBoxCmdAbort);
            this.Controls.Add(this.textBoxCmd);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.labelIP);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(422, 39);
            this.Name = "FormWDT";
            this.Text = "死手系统";
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
        private System.Windows.Forms.TextBox textBoxMaxCount;
        private System.Windows.Forms.Label labelLost;
        private System.Windows.Forms.Label labelCmd;
        private System.Windows.Forms.TextBox textBoxCmd;
        private System.Windows.Forms.TextBox textBoxCmdAbort;
        private System.Windows.Forms.Label labelCmdAbort;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLostCount;
        private System.Windows.Forms.Button buttonDefault;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonHide;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLostCountValue;
    }
}

