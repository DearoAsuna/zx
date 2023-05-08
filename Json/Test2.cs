using System;
using Microsoft.Extensions.Options;

namespace Json
{
    public class Test2
    {
        private readonly IOptionsSnapshot<Proxy> pSnapshot;

        public Test2(IOptionsSnapshot<Proxy> pSnapshot)
        {
            this.pSnapshot = pSnapshot;
        }

        public void Test1()
        {
            Console.WriteLine(pSnapshot.Value.Port);
        }
    }
}
