namespace 取消
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var can = new CancellationTokenSource();
            //can.CancelAfter(5000);
             DownloadTask2("http://www.youzack.com", 1000,can.Token);
            if (Console.ReadLine().Equals("q"))
            {
                
            }
            can.Cancel();
            Console.Read();

        }

        static async Task DownloadTask(string url,int num,CancellationToken cancellation)
        {
            using (HttpClient ht=new HttpClient())
            {
                for (int i = 0; i < num; i++)
                {
                    var s1 = await ht.GetStringAsync(url);
                    Console.WriteLine($"{DateTime.Now}:{url}");
                    cancellation.ThrowIfCancellationRequested();
                }
            }
        }
        static async Task DownloadTask1(string url, int num, CancellationToken cancellation)
        {
            using (HttpClient ht = new HttpClient())
            {
                for (int i = 0; i < num; i++)
                {
                    var res = await ht.GetAsync(url, cancellation);
                    var read =await res.Content.ReadAsStringAsync();
                    Console.WriteLine($"{DateTime.Now}:{read}");
                    
                }
            }
        }
        static async Task DownloadTask2(string url, int num, CancellationToken cancellation)
        {
            using (HttpClient ht = new HttpClient())
            {
                for (int i = 0; i < num; i++)
                {
                    var res = await ht.GetAsync(url, cancellation);
                    var read = await res.Content.ReadAsStringAsync();
                    Console.WriteLine($"{DateTime.Now}:{url}");
                }
            }

        }
    }
}