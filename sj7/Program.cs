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
    public class DishEventArgs : EventArgs
    {
        public string name { get; set; }
        public string size { get; set; }
    }
   // public delegate void OdEventH(GK c1, DishEventArgs d1);
    public class GK
    {
        public event EventHandler Order;
        public double Bill { get; set; }
        public void Pay()
        {
            Console.WriteLine("l will give you" + Bill);
        }
        public void Walkin()
        {
            Console.WriteLine("Walking");
        }
        public void Think()
        {      
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Thinking");
            }
            OnOrder("gbjd","l");
        }
        protected void OnOrder(string DishName,string size)
        {
            if (Order != null)
            {
                DishEventArgs d1 = new DishEventArgs();
                d1.name = DishName;
                d1.size = size;
                Order.Invoke(this, d1);
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
        internal void A(object o1, EventArgs e1)
        {
            GK c1 = o1 as GK;
            DishEventArgs d1 = e1 as DishEventArgs;
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
