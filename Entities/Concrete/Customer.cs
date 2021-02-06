using Core.Entities;

using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Customer:IEntities
    {
        public string CustomerId { get; set; }
        public string ContactName { get; set; }
        public string CompanyNmae { get; set; }
        public string City { get; set; }
    }
}
