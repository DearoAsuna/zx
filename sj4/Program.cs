using System;
using System.Threading;

namespace sj4
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            Waiter w1 = new Waiter();
            c1.Order += w1.Action;
            c1.Action();
            c1.PayTheBill();
        }
    }
    public  class OrderEventArgs:EventArgs
    {
        public string  DishName { get; set; }
        public string size { get; set; }

    }

    public delegate void OrderEventHandler(Customer c1, OrderEventArgs e);
        
    public class Customer
    {
        private OrderEventHandler orderEventHandler;
        public event OrderEventHandler Order
        {
            add
            {
                this.orderEventHandler += value;
            }
            remove
            {
                this.orderEventHandler -= value;
            }
        }
        public double Bill { get; set; }
        public void PayTheBill()
        {
            Console.WriteLine("i will pay ${0}",this.Bill); 
        }

        public void Walkin()
        {
            Console.WriteLine("Walk into the restaurant");
        }
        public void think()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("let me thinging");
                Thread.Sleep(1000);
            }
            if (this.orderEventHandler!=null)
            {
                OrderEventArgs e = new OrderEventArgs();
                e.DishName = "gbjd";
                e.size = "large";
                this.orderEventHandler.Invoke(this, e);

            }
        }
        public void Action()
        {
            Console.ReadLine();
            this.Walkin();
            this.think();
        }
    }
    public class Waiter
    {
        public void Action(Customer c1, OrderEventArgs e)
        {
            Console.WriteLine("dish - {0}",e.DishName);
            double price = 10;
            switch (e.size)
            {
                case "small":
                    price = price * 0.5;
                    break;
                case "large":
                    price = price * 1.5;
                    break;
                default:
                    break;
            }
            c1.Bill += price;
        }
    }
}
