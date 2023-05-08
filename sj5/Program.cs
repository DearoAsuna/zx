using System;

namespace sj5
{
    class Program
    {
        static void Main(string[] args)
        {
            GK gK = new GK();
            Fwy fwy = new Fwy();
            gK.Order += fwy.A;
            gK.Ac();                  
        }
    }
    public class DishEventArgs: EventArgs
    {
        public string name { get; set; }
        public string size  { get; set; }
    }
    public delegate void OdEventH(GK c1, DishEventArgs d1);
    public class GK
    {
        private OdEventH OdEventH1;
        public event OdEventH Order
        {
            add
            { this.OdEventH1 += value;} 
            remove
            {
                this.OdEventH1 -= value;
            }
        }
        public double Bill { get; set; }
        public void Pay()
        {
            Console.WriteLine("l will give you"+Bill);
        }
        public void Walkin()
        {
            Console.WriteLine("Walking");
        }
        public void Think()
        {
            DishEventArgs d1 = new DishEventArgs();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Thinking");                
            }
            if (this.OdEventH1!=null)
            {
                d1.name = "smd";
                d1.size = "l";
                this.OdEventH1.Invoke(this, d1);
            }
        }
        public void Ac()
        {
            Walkin();
            Think();
        }
    }

    public class Fwy
    {
        internal void A(GK c1, DishEventArgs d1)
        {
            Console.WriteLine("i will give you" + d1.name);
            double p = 10;
            switch (d1.size)
            {
                case "l":
                    p = p * 1.5;
                    break;
                case "m":
                    break;
                case "S":
                    p = p * 0.5;
                    break;
                default:
                    break;
            }
            c1.Bill += p;
            c1.Pay();
        }
    }

}
