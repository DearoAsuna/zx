namespace dxc4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var d = Thread.AllocateDataSlot();
            Thread.SetData(d,"smd?");
            var t1 = new Thread(() =>
            {
                Console.WriteLine($"子线程:{Thread.GetData(d)}");
            });
            t1.Start();
            Console.WriteLine($"主线程:{Thread.GetData(d)}");
        }
    }
}