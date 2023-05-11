using System;

using DiInterfers;

namespace Service
{
    public class Micro:IMicroPhone
    {
        public Micro()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
}
