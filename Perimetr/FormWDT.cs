using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Perimetr
{
    public partial class FormWDT : Form
    {
        DeadHand dh = new DeadHand();

        public FormWDT()
        {
            InitializeComponent();

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
    }
}
