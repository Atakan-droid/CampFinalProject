using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{       //ciplak class kalmasın
     public class Category :IEntities
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
