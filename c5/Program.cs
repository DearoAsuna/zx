using System;

namespace c5
{
    class Program
    {
         static void Main(string[] args)
        {          
            int rs = CalculateSum(1,2,3,4 );
            Console.WriteLine(rs); 
            string str = "smd,smd1.smd2/smd3";
            string[] rs1 = str.Split(',', '.', '/');
            foreach (var name in rs1)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
         static int CalculateSum(params int[] intArray)
            {
                int sum = 0;
                foreach (var i in intArray)
                {
                    sum += i;
                }
                return sum;
            }
    }
   
}
