using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pingWDT
{
    class DH_DESC
    {
        /// <summary>
        /// 发送心跳包的周期
        /// </summary>
        public double period = 40;

        /// <summary>
        /// 丢失多少个心跳包以后执行命令
        /// </summary>
        public int max_count = 5;

        /// <summary>
        /// 要测试的IP地址
        /// </summary>
        public string target_IP = "166.111.8.28";

        /// <summary>
        /// 要测试的IP地址
        /// </summary>
        public string cmd = @"shutdown /s /t 30";

        /// <summary>
        /// 要测试的IP地址
        /// </summary>
        public string cmd_abort = @"shutdown /a";

        public DH_DESC() { }

        public DH_DESC(double period, int max_count, string target_IP, string cmd, string cmd_abort)
        {
            this.period = period;
            this.max_count = max_count;
            this.target_IP = target_IP;
            this.cmd = cmd;
            this.cmd_abort = cmd_abort;
        }
    }
}
