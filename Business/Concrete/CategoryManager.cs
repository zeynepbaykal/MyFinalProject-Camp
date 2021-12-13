using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;//injection

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            //iş kodları yazılır
            return _categoryDal.GetAll();
           
        }

        //select *from Categories where CategoryId=3
        public Category GetById(int categoryId)
        {
            //select *from Categories where CategoryId=3
            return _categoryDal.Get(c=>c.CategoryId==categoryId);
        }
    }
}
