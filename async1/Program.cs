using System.Text.Encodings.Web;

namespace async1
{
    internal  class Program
    {
        static  void Main(string[] args)
        {
            #region MyRegion


            /*var downloadHttpTask = await DownloadHttpTask("smd", @"D:\test\1.text");
                   Console.WriteLine(downloadHttpTask);*/
            #endregion


            #region MyRegion


            /*var result = File.ReadAllTextAsync(@"D:\test\1.text");
                     var r1 = result.Result;
                     Console.WriteLine(r1);*/
            #endregion


            #region 

            

            #endregion

        }

        /*static async Task<int> DownloadHttpTask(string url, string filename)
        {
            using (HttpClient hc=new HttpClient())
            {
                string html=await hc.GetStringAsync(url);
                await File.WriteAllTextAsync(filename, html);
                return html.Length;
            }
            

        }*/
    }
}