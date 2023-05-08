namespace when
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            /*var r1 = File.ReadAllTextAsync(@"D:\test\1.txt");
            var r2 = File.ReadAllTextAsync(@"D:\test\2.txt");
            var r3 = File.ReadAllTextAsync(@"D:\test\3.txt");
            var waitAll = await Task.WhenAll(r1, r2, r3);
            foreach (var i in waitAll)
            {
                Console.WriteLine(i);
            }*/
            var f1 = Directory.GetFiles(@"D:\test");
            
            /*foreach (var f in f1)
            {
                var r1 =await ReadChar(f);
                count += r1;
            }
            Console.WriteLine(count);*/
            var t1 = new Task<int>[f1.Length];
            for (int i = 0; i < t1.Length; i++)
            {
                var filename = f1[i];
                var r2 = ReadChar(filename);
                t1[i] = r2;
            }   

            var whenAll =await Task.WhenAll(t1);
            int count = whenAll.Sum();
            Console.WriteLine(count);
        }

        static async Task<int> ReadChar(string filename)
        {
            var read =await File.ReadAllTextAsync(filename);
            return read.Length;
        }
    }
}