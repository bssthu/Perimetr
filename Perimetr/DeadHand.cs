using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace Perimetr
{
    class DeadHand
    {
        DH_DESC desc = new DH_DESC();

        /// <summary>
        /// 失联计数
        /// </summary>
        public int lost_count
        {
            get;
            private set;
        }

        Timer timer = new Timer();

        public DeadHand()
        {
            lost_count = 0;
            timer.Stop();
            timer.Elapsed += timer_Elapsed;
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
        }

        /// <summary>
        /// 执行 ping 动作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
