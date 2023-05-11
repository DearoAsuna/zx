using System;
using DiInterfers;

namespace Service
{
    public class Apple: IPhone
    {
        public IMicroPhone MinMicroPhone { get; set; }
        public IPower Power { get; set; }
        public Apple(IPower power)
        {
            Power = power;
            Console.WriteLine($"{GetType().Name} 构造函数");
        }
        public void Call()
        {
            Console.WriteLine("Apple");
        }

        public void Init231233(IPower iPower)
        {
            Console.WriteLine($"{GetType().Name} 构造函数");
        }

    

      

        
    }
}
