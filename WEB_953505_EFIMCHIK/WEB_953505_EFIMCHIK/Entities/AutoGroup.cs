using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_953505_EFIMCHIK.Entities
{
    public class AutoGroup
    {
        public int AutoGroupId { get; set; }
        public string GroupName { get; set; }

        public List<Auto> Cars { get; set; }
    }
}
