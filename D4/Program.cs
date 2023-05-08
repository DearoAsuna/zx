using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new Engine();
            var car = new Car(engine);
            car.Run(10);
            Console.WriteLine(car.Speed);
        }
    }
    class Engine
    {
        public int RPM { get; set; }
        public void Work(int ags)
        {
            this.RPM = 1000 * ags;
        }
    }
    class Car
    {
        private Engine _engine;
        public Car(Engine engine)
        {
            _engine = engine;
        }
        public int Speed { get; set; }
        public void Run(int ags)
        {
            _engine.Work(ags);
            this.Speed = _engine.RPM / 100;
        }

    }
}
