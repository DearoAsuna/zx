using System;

namespace sj6
{
    class Program
    {
        static void Main(string[] args)
        {
            Smd s1 = new Smd();
            Sleep sleep = new Sleep();
            s1.SmdSleep += sleep.Ac;
            s1.Ac();
            

        }
    }

    public class SmdTimeEventArgs : EventArgs
    {
        public int time { get; set; }
    }
    public delegate void SleepEventHandle(Smd s1, SmdTimeEventArgs st1);
    public class Smd
    {
        private SleepEventHandle sleep;

        public event SleepEventHandle SmdSleep
        {
            add
            {
                sleep += value;
            }
            remove
            {
                sleep -= value;
            }
        }

        public string Zk { get; set; }
        
        public void Sleep()
        {
            Console.WriteLine("i want to sleep");
        }
        public void Sleeping()
        {
            SmdTimeEventArgs s11 = new SmdTimeEventArgs();
            
            if (this.sleep!= null)
            {
                s11.time = 666;
                this.sleep.Invoke(this, s11);
            }
        }
        public void Ac()
        {
            Sleep();
            Sleeping();
        }
        public void SleepZk()
        {
            Console.WriteLine("i sleep "+Zk);
        }


    }
    public class Sleep
    {
        internal void Ac(Smd s1, SmdTimeEventArgs st1)
        {
            Console.WriteLine("hava a good night");
            if (st1.time>700)
            {
                s1.Zk = "very good";
            }
           else if(st1.time>500)
            {
                s1.Zk = "good";
            }
            else if (st1.time>200)
            {
                s1.Zk = "bad";
            }
            s1.SleepZk();
        }
    }
}
