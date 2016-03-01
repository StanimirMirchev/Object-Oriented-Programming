using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AsynchronousTimer
{
    class AsyncTimer
    {
         private Action<int> actionMethod;
        private int interval;
        private int ticks;

        public AsyncTimer(Action<int> actionMethod, int interval, int ticks)
        {
            this.ActionMethod = actionMethod;
            this.Interval = interval;
            this.Ticks = ticks;
        }

        public Action<int> ActionMethod
        {
            get { return this.actionMethod; }
            set { this.actionMethod = value; }
        }
        public int Interval
        {
            get { return this.interval; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Interval must be positive!");
                }
                this.interval = value;
            }
        }

        public int Ticks
        {
            get { return this.ticks; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Ticks must be positive!");
                }
                this.ticks = value;
            }
        }

        private void DoWork()
        {
            while (this.Ticks > 0)
            {
                Thread.Sleep(this.Interval);

                if (ActionMethod != null)
                {
                    ActionMethod(this.Ticks);
                }
                this.Ticks--;
            }
        }

        public void Start()
        {
            Thread thread = new Thread(this.DoWork);
            thread.Start();
        }
    }
}



