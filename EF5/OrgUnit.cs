using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF5
{
    class OrgUnit
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public OrgUnit? Parent { get; set; }

        public List<OrgUnit> Children { get; set; } = new List<OrgUnit>();

    }
}
