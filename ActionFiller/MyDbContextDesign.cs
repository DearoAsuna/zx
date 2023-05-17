/*
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EFCore11
{
    public class MyDbContextDesign
        :IDesignTimeDbContextFactory<MyDbContext>
    {
        public MyDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MyDbContext>();
            var server = 
                builder.UseSqlServer("Server=.;" +
                                     "Data Source=LAPTOP-5AQ8PCDO\\SQLEXPRESS;" +
                                     " Database = WebAPIdemo2;Encrypt=True;Trusted_Connection=True;" +
                                     "TrustServerCertificate=True;"
            );
            var context = new MyDbContext(server.Options);
            return context;
        }
    }
}
*/
