using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_953505_EFIMCHIK.Entities
{
    public class Auto
    {
        public int AutoId { get; set; }
        public string AutoName { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }

        public int AutoGroupId { get; set; }
        public AutoGroup Group { get; set; }
    }
}
