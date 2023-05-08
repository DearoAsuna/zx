using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c3
{
    class Program
    {
        static void Main(string[] args)
        {
            Stu s1 = new Stu();
            s1["math"] = 90;
            var ms = s1["math"];
            Console.WriteLine(ms==null);
            Console.ReadKey();
        }
    }
    class Stu
    {
        private Dictionary<string, int> sc = new Dictionary<string, int>();
        public int? this[string sub]
        {
            get 
            {
                if (this.sc.ContainsKey(sub))
                {
                    return this.sc[sub];
                }
                else
                    return null;
            }
            set 
            {
                if (value.HasValue==false)
                {
                    throw new Exception("cannot be null");
                }
                if (this.sc.ContainsKey(sub))
                {
                    this.sc[sub] = value.Value;
                }
                else
                    this.sc.Add(sub, value.Value);
            }
        }

    }
}
