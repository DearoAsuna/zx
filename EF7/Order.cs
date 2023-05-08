using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF7
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Delivery Delivery { get; set; }
        public long DeliveryId { get; set; }
    }
}
