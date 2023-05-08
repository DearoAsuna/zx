using System;

namespace Animals
{
    public class Cat
    {
        public void Voice(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine("Miao?");
            }
        }
    }
}
