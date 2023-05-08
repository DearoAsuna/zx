namespace lq1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] a= new int[] { 1, 2, 123, 123, 123, 1231234, 443 };
           /*IEnumerable<int> r1 = a.Where(a => a > 10);
           foreach (var a1 in r1)
           {
               Console.WriteLine(a1);
           }*/
           var ints = MyWhere1(a, a => a > 10);
           foreach (var i in ints)
           {
               Console.WriteLine(i);
           }
           
        }

        static IEnumerable<int> MyWhere(IEnumerable<int> items, Func<int, bool> f1)
        {
            var ints = new List<int>();
            foreach (var item in items)
            {
                if (f1(item)==true)
                {
                    ints.Add(item);
                }
            }
            
            return null;
        }
        static IEnumerable<int> MyWhere1(IEnumerable<int> items, Func<int, bool> f1)
        {
            var ints = new List<int>();
            foreach (var item in items)
            {
                if (f1(item) == true)
                {
                    Console.WriteLine("?");
                    yield return item;
                }
            }

        }
        
    }
}