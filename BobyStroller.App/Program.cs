using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Loader;

namespace BobyStroller.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var folder = Path.Combine(Environment.CurrentDirectory, "Animals");
            var files = Directory.GetFiles(folder);
            var animaTypes = new List<Type>();
            foreach (var file in files)
            {
                var assembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(file);
                var types = assembly.GetTypes();
                foreach (var t in types)
                {
                    if (t.GetMethod("Voice") != null)
                    {
                        animaTypes.Add(t);
                    }
                }
            }

            while (true)
            {
                for (int i = 0; i < animaTypes.Count; i++)
                {
                    Console.WriteLine($"{i+1},{animaTypes[i].Name}");
                }

                Console.WriteLine("==========================");
                Console.WriteLine("Please choose animal");
                int index = int.Parse(Console.ReadLine());
                if (index>animaTypes.Count||index<1)
                {
                    Console.WriteLine("No such an animal");
                    continue;
                }

                int times = int.Parse(Console.ReadLine());
                var t = animaTypes[index - 1];
                var m = t.GetMethod("Voice");
                var o = Activator.CreateInstance(t);
                m.Invoke(o, new object[times]);

            }
        }

    }
}
