using System;
using System.Collections.Generic;
namespace fx3
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<int> list = new List<int>();
            for (int i = 0; i <10; i++)
            {
                list.Add(i);
            }

            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
