using EFCore11;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ActionFiller
{
    public class PersonConfig:IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("T_Person");
            builder.HasMany(a => a.Books)
                .WithOne(a => a.Person);
        }
    }
}
