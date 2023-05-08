using System;
namespace a2
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductFactory p1 = new ProductFactory();
            WrapFactory w1 = new WrapFactory();
            Func<Product> f1 = new Func<Product>(p1.Makepizz);
            Func<Product> f2 = new Func<Product>(p1.MakeToyCar);
            Logger l1 = new Logger();
            Action<Product> la = new Action<Product>(l1.Log);
            Box box1 = w1.WrapProduct(f1,la);
            Box box2 = w1.WrapProduct(f2,la);
            Console.WriteLine(box1.product.name);
            Console.WriteLine(box2.product.name);
            Console.ReadKey();
        }
    }
    class Product
    {
        public string name { set; get; }
        public double Price { get; set; }
    }
    class Logger
    {
        public void Log(Product pr)
        {
            Console.WriteLine("Pro'{0}' in '{1}'",pr.name,DateTime.UtcNow);
        }

    }

    class Box
    {
        public Product product { get; set; }
    }
    class WrapFactory
    {
        public Box WrapProduct(Func<Product>getP,Action<Product>logCallback)
        {
            Box box = new Box();
            Product p1 = getP.Invoke();
            logCallback(p1);
            box.product = p1;
            return box;
        }
    }
    class ProductFactory
    {
        public Product Makepizz()
        {
            Product p1 = new Product();
            p1.name = "Pizza";
            return p1;
        }
        public Product MakeToyCar()
        {
            Product p1 = new Product();
            p1.name = "car";
            return p1;
        }

    }

}
