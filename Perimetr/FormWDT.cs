using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Perimetr
{
    public partial class FormWDT : Form
    {
        DeadHand dh = new DeadHand();

        protected bool isFirstShown = true;

        public FormWDT()
        {
            InitializeComponent();

            dh.lost_countChanged += lost_countChanged;
            dh.kill += runCmd;
            dh.kill += onRunKillCmd;
            dh.cancelKill += runCmd;
            dh.printMsg += showMsgOnStatusBar;

            // load settings
            DH_DESC saved_desc;
            if (Properties.Settings.Default.saved)
            {
                saved_desc = new DH_DESC(Properties.Settings.Default.period,
                        Properties.Settings.Default.max_count,
                        Properties.Settings.Default.target_IP,
                        Properties.Settings.Default.cmd,
                        Properties.Settings.Default.cmd_abort);
            }
            else
            {
                saved_desc = new DH_DESC();
            }
            dh.ApplyConfig(saved_desc);
            textBoxPeroid.Text = saved_desc.period.ToString();
            textBoxMaxCount.Text = saved_desc.max_count.ToString();
            textBoxIP.Text = saved_desc.target_IP;
            textBoxCmd.Text = saved_desc.cmd;
            textBoxCmdAbort.Text = saved_desc.cmd_abort;
            buttonApply.Enabled = false;
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            try
            {
                double period = Convert.ToDouble(textBoxPeroid.Text);
                int max_count = Convert.ToInt32(textBoxMaxCount.Text);
                DH_DESC desc = new DH_DESC(period, max_count, textBoxIP.Text.Trim(), textBoxCmd.Text, textBoxCmdAbort.Text);
                dh.ApplyConfig(desc);
                saveSettings(desc);
                buttonApply.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误");
            }
        }

        private void buttonHide_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void buttonDefault_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确实要恢复到默认设置？", "重置", MessageBoxButtons.YesNo)
                    == DialogResult.Yes)
            {
                DH_DESC default_desc = new DH_DESC();
                dh.ApplyConfig(default_desc);
                saveSettings(default_desc);
                textBoxPeroid.Text = default_desc.period.ToString();
                textBoxMaxCount.Text = default_desc.max_count.ToString();
                textBoxIP.Text = default_desc.target_IP;
                textBoxCmd.Text = default_desc.cmd;
                textBoxCmdAbort.Text = default_desc.cmd_abort;
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            dh.Reset();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否访问项目主页 https://github.com/bssthu/Perimetr ？", "关于", MessageBoxButtons.YesNo)
                    == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://github.com/bssthu/Perimetr");
            }
        }

        private void textBoxs_TextChanged(object sender, EventArgs e)
        {
            buttonApply.Enabled = true;
        }

        private void saveSettings(DH_DESC desc)
        {
            Properties.Settings.Default.period = desc.period;
            Properties.Settings.Default.max_count = desc.max_count;
            Properties.Settings.Default.target_IP = desc.target_IP;
            Properties.Settings.Default.cmd = desc.cmd;
            Properties.Settings.Default.cmd_abort = desc.cmd_abort;
            Properties.Settings.Default.saved = true;
            Properties.Settings.Default.Save();
        }

        private void lost_countChanged(int count)
        {
            toolStripStatusLabelLostCountValue.Text = count.ToString();
            if (count == 0)
            {
                toolStripStatusLabelStatus.Text = "就绪";
            }
        }

        private void runCmd(string cmd)
        {
            try
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/C " + cmd;
                process.StartInfo = startInfo;
                process.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "无法执行命令");
            }
        }

        private void onRunKillCmd(string cmd)
        {
            notifyIcon1.BalloonTipText = "命令已执行";
            notifyIcon1.ShowBalloonTip(10000);
            if (MessageBox.Show("命令已执行，是否确认", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                    == DialogResult.No)
            {
                dh.AbortCmd();
            }
        }

        private void showMsgOnStatusBar(string msg)
        {
            toolStripStatusLabelStatus.Text = msg;
            notifyIcon1.BalloonTipText = msg;
            notifyIcon1.ShowBalloonTip(10000);
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Visible = true;
        }

        protected override void SetVisibleCore(bool value)
        {
            if (isFirstShown)
            {
                isFirstShown = false;
                notifyIcon1.BalloonTipText = "死手系统已启动";
                notifyIcon1.ShowBalloonTip(1000);
            }
            else
            {
                base.SetVisibleCore(value);
            }
        }
    }
}
