namespace EF7
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using (var i=new MyDbcontext())
            {
                var order = new Order()
                {
                    Name = "司马刁历险记"
                };
                var delivery = new Delivery()
                {
                    Companyname = "运费",
                    Number = "666"
                }; 
                delivery.Order= order;
                order.Delivery = delivery;
                
                i.Deliveries.Add(delivery);
              
                var saveChangesAsync =await i.SaveChangesAsync();
                Console.WriteLine(saveChangesAsync);
            }
        }
    }
}