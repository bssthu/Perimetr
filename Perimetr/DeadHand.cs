using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Timers;

namespace Perimetr
{
    class DeadHand
    {
        DH_DESC desc = new DH_DESC();
        Ping pingSender = new Ping();


        /// <summary>
        /// 失联计数
        /// </summary>
        public int lost_count
        {
            get;
            private set;
        }

        System.Timers.Timer timer = new System.Timers.Timer();

        public DeadHand()
        {
            lost_count = 0;
            timer.Stop();
            timer.Elapsed += timer_Elapsed;
            pingSender.PingCompleted += pingCompletedCallback;
        }

        public void ApplyConfig(DH_DESC desc)
        {
            if (desc.period > 0 && desc.max_count > 0)
            {
                this.desc = desc;
                timer.Interval = desc.period * 1000;    // ms
                timer.Start();
            }
        }

        /// <summary>
        /// 重置计数
        /// </summary>
        public void Reset()
        {
            lost_count = 0;
            pingSender.SendAsyncCancel();
        }

        /// <summary>
        /// 执行 ping 动作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                ping(desc.target_IP);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex.Message);
            }
        }

        private void ping(string ip_addr)
        {
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] buf = Encoding.ASCII.GetBytes(data);
            int timeout = 10000;    // 10s

            PingOptions options = new PingOptions(64, true);

            pingSender.SendAsync(ip_addr, timeout, buf);
        }

        private void pingCompletedCallback(object sender, PingCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                lost_count++;
                System.Diagnostics.Trace.WriteLine(e.Error.ToString());
            }
        }
    }
}
