using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D6
{
    class Program
    {
        static void Main(string[] args)
        {
            var fan = new DeskFan(new PowerSupply());
            Console.WriteLine(fan.Work());
        }
    }
    public class PowerSupply
    {
        public virtual int GetPower()
        {
            return 100;
        }
    }
    public interface IPowerSupply
    {
        int GetPower(); 
    }
    public class DeskFan
    {

        private PowerSupply _powerSupply;
        public DeskFan(PowerSupply powerSupply)
        {
            _powerSupply = powerSupply;
        }
        public string Work()
        {
            int power = _powerSupply.GetPower();
            if (power < 0)
            {
                return "Wont work";
            }
            else if (power < 100)
            {
                return "Slow";
            }
            else if (power < 200)
            {
                return "Work fine";
            }
            else return "Explostion";

        }

    }
    



}
