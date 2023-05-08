using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D5
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User(new NokiaPhone());
            user.UserPhone();
        }
    }
    interface IPhone
    {
        void Dali();
        void PickUp();
        void Receove();
        void Send();
    }
    class NokiaPhone : IPhone
    {
        public void Dali()
        {
            Console.WriteLine("Calling...");
        }

        public void PickUp()
        {
            Console.WriteLine("Hello this is Tim");
        }

        public void Receove()
        {
            Console.WriteLine("ring..");
        }

        public void Send()
        {
            Console.WriteLine("Sended");
        }
    }
    class User
    {
        private IPhone _phone;
        public User(IPhone phone)
        {
            _phone = phone;
        }
        public void UserPhone()
        {
            _phone.Dali();
            _phone.PickUp();
            _phone.Send();
            _phone.Receove();

        }
    }

}
