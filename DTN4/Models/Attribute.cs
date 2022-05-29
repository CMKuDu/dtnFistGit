using System;
using System.Collections.Generic;

#nullable disable

namespace DTN4.Models
{
    public partial class Attribute
    {
        public Attribute()
        {
            AttributesPrices = new HashSet<AttributesPrice>();
        }

        public int AttributesId { get; set; }
        public string AttributesName { get; set; }

        public virtual ICollection<AttributesPrice> AttributesPrices { get; set; }
    }
}
