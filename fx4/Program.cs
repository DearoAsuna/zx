using System;
using System.Collections.Generic;


namespace fx4
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<int, string> dic = new Dictionary<int, string>();
            dic[1] = "smd";
            dic[2] = "smd2";
            Console.WriteLine(dic[1]);

        }
    }
}
