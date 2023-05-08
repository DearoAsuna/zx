using System;

namespace f1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a1 = new Apple() { Color = "red" };
            var b1 = new Book() { Name = "smd" };
            Box<Apple> ta1 = new Box<Apple>(){Car = a1};
            Box<Book> tb1 = new Box<Book>(){Car = b1};

        }
    }
    class Book
    {
        public string Name { get; set; }
    }
    class Apple
    {
        public string Color
        {
            get;
            set;
        }
    }

    class Box<TCar>
    {
        public TCar Car { get; set; }
    }

}
