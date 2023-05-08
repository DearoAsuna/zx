namespace async2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using (HttpClient ht=new HttpClient())
            {
                var s1 = await ht.GetStringAsync("https://www.baidu.com");
                Console.WriteLine(s1);
            }
            string Txt = "hello smd";
            string filename=@"D:\\test\\1.text";
            await File.WriteAllTextAsync(filename,Txt);
            Console.WriteLine("CG");
            var r1 = await File.ReadAllTextAsync(filename);
            Console.WriteLine(r1);
        }
    }
}