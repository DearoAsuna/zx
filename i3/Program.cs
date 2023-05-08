using System;
namespace i3
{
    class Program
    {
        static void Main(string[] args)
        {
            var wk = new WarmKiller();
            wk.love();
            var wk1 = (IGen)wk;
            wk.love();
        }
    }

    interface IGen
    {
        void love();
    }

    interface IKiller
    {
        void kill();
    }

    class WarmKiller:IGen,IKiller
    {
        
        public void love()
        {
            Console.WriteLine("I love you....");
        }

        void IKiller.kill()
        {
            Console.WriteLine("kill");
        }

    }
}
