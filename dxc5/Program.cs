namespace dxc5
{
    internal class Program
    {
        [ThreadStatic]
        private static string a1=string.Empty;
        static void Main(string[] args)
        {
            a1 = "smd?";
            var t1 = new Thread((() =>
            {
                Console.WriteLine(a1+"111");
            }));
            t1.Start();
            Console.WriteLine(a1+"10086");
        }
    }
}