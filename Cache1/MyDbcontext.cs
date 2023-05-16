namespace Cache1
{
    public class MyDbcontext
    {
        public static Task<Book?> GetBookAync(int id)
        {
           var i= GetByid(id);
           var fromResult = Task.FromResult(i);
           return fromResult;
        }


        public static Book GetByid(int id)
        {
            switch (id)
            {
                case 1:
                    return new Book(1, "smd冒险日记");
                case 2:
                    return new Book(2, "smd冒险日记2");
                case 3:
                    return new Book(3, "smd冒险日记4");
                default: 
                   return null;

            }
        }
    }
}
