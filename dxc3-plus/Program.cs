using System.Diagnostics;

namespace dxc3_plus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var f1 = new Func<int>((() =>
            {
                Console.WriteLine("smd?"+DateTime.Now);
                return DateTime.Now.Year;
            }));
            var call = Call(f1);
            Debug.WriteLine("=================");
            var i = f1.Invoke();
            Console.WriteLine(i);
        }

        private static Func<T> Call<T>(Func<T> f1)
        {
          T t=default(T);
          var t1 = new Thread((() =>
          {
              f1.Invoke();
          }));
          t1.Start();
          return new Func<T>((() =>
          {
              t1.Join();
              return t;
          }));
        }
    }
}