using Business.Abstract;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;

        }

        public IResult Add(Category category)
        {
            BusinessRules.Run();
            _categoryDal.Add(category);
            return new SuccessResult();
        }

        public IDataResult<List<Category>> GetAll()
        {
            
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll(),"Perfect");
        }

        //Select * from Categories where CategoryId = 3
        public IDataResult<Category> GetById(int categoryID)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(c => c.CategoryId == categoryID));
        }

    }
}
