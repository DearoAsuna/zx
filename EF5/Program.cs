namespace EF5
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            #region add

            /*
             var unit = new OrgUnit()
            {
               Name = "smd集团全球总部"
            };
            var unit1 = new OrgUnit()
            {
                Name = "smd集团亚洲总部"
            };
            var unit2 = new OrgUnit()
            {
                Name = "smd集团非洲总部"
            };
           
            var unit3 = new OrgUnit()
            {
                Name = "smd集团中国总部"
            };
           
            var unit4 = new OrgUnit()
            {
                Name = "smd集团南非总部"
            };
           
            unit.Children.Add(unit2);
            unit.Children.Add(unit1);
            unit1.Children.Add(unit3);
            unit2.Children.Add(unit4);
            using (var i=new MyDbcontext())
            {
                i.OrgUnit.Add(unit);
                var saveChangesAsync = await i.SaveChangesAsync();
                Console.WriteLine(saveChangesAsync);
            }*/

            #endregion

            using (var d=new MyDbcontext())
            {
                var unit = d.OrgUnit.Single(o => o.Parent == null);
                Console.WriteLine(unit.Name);
                PrintChildren(1,d,unit);
            }
            

        }

        static void PrintChildren(int idetlevel, MyDbcontext ctx, OrgUnit parent)
        {
            var units = ctx.OrgUnit.Where(o => o.Parent == parent);
            var list = units.ToList();
            foreach (var unit in list)
            {
                Console.WriteLine(new string('\t',idetlevel)+unit.Name);
                    PrintChildren(idetlevel+1,ctx,unit);
            }
        }
    }
}