using Entities.Concrete;
using Core.DataAccess;
using Entities.DTOs;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();
        
    }
}
//Code refactoring denir 