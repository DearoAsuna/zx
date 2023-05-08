using System;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace i1
{

    class Drive
    {
        private IVehicle _vehicle;

        public Drive(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }

        public void Drive1()
        {
            _vehicle.Run();
        }
    }

    class Fire
    {
        private IWeapon _fire;

        public Fire(IWeapon fire)
        {
            _fire = fire;
        }

        public void Fire1()
        {
            _fire.Fire();
        }
    }

    class Tank
    {
        private ITank _tank;

        public Tank(ITank tank)
        {
            _tank = tank;
        }

        public void Move()
        {
            _tank.Fire();
            _tank.Run();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var sc = new ServiceCollection();
            sc.AddScoped(typeof(ITank), typeof(HeavyTank));
            sc.AddScoped<Tank>();
            var sp = sc.BuildServiceProvider();
            /*=====================================================================*/
            var driver = sp.GetService<Tank>();
            driver.Move();


            #region MyRegion

            /*ITank tank = new HeavyTank();
           Console.WriteLine("===============");
           var t = tank.GetType();
           object o = Activator.CreateInstance(t);
           MethodInfo fireMi = t.GetMethod("Fire");
           MethodInfo runMi = t.GetMethod("Run");
           fireMi.Invoke(o, null);
           runMi.Invoke(o, null);*/

            #endregion
        }
    }
    interface IVehicle
    {
        void Run();
    }
    interface ITank:IVehicle,IWeapon
    {
    }

     interface IWeapon
    {
        void Fire();

    }
    class Car:IVehicle
    {
        public void Run()
        {
            Console.WriteLine("Car is running");
        }
    }
    class Turck : IVehicle
    {
        public void Run()
        {
            Console.WriteLine("Turck is running");
        }
    }
    
    class Light: ITank
    {
        public void Fire()
        {
            Console.WriteLine("Boom!");
        }

        public void Run()
        {
            Console.WriteLine("Ka Ka ka..");
        }
    }
    class  MediumTank: ITank
    {
        public void Fire()
        {
            Console.WriteLine("Boom!");
        }

        public void Run()
        {
            Console.WriteLine("Ka Ka ka..M");
        }

    }
    class HeavyTank: ITank
    {
        public void Fire()
        {
            Console.WriteLine("Boom!");
        }

        public void Run()
        {
            Console.WriteLine("Ka Ka ka..H");
        }

    }

}
