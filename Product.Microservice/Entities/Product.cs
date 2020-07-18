using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.Microservice.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int Rate { get; set; }
    }
}
