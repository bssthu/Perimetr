using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pingWDT
{
    public partial class FormWDT : Form
    {
        public FormWDT()
        {
            InitializeComponent();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            try
            {
                double period = Convert.ToDouble(textBoxPeroid.Text);
                int max_count = Convert.ToInt32(textBoxMaxCount.Text);
                DH_DESC desc = new DH_DESC(period, max_count, textBoxIP.Text.Trim(), textBoxCmd.Text, textBoxCmdAbort.Text);
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
                textBoxPeroid.Text = default_desc.period.ToString();
                textBoxMaxCount.Text = default_desc.max_count.ToString();
                textBoxIP.Text = default_desc.target_IP;
                textBoxCmd.Text = default_desc.cmd;
                textBoxCmdAbort.Text = default_desc.cmd_abort;
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {

        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否访问项目主页 https://github.com/bssthu/pingWDT ？", "关于", MessageBoxButtons.YesNo)
                    == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://github.com/bssthu/pingWDT");
            }
        }

        private void textBoxs_TextChanged(object sender, EventArgs e)
        {
            buttonApply.Enabled = true;
        }
    }
}
