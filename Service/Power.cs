using System;
using System.Threading.Channels;
using DiInterfers;

namespace Service
{
    public class Power:IPower
    {
        public Power(IEnumerable<IMicroPhone> a)
        {
            Console.WriteLine($"{GetType().Name}");
        }
    }
}
