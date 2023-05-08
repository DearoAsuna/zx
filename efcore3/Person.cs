using System;
using System.Collections.Generic;

namespace EFcore3;

public partial class Person
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Age { get; set; }

    public string? Sex { get; set; }


    public override string ToString()
    {
        return $"{Id} {Name} {Age} {Sex}";
    }
}
