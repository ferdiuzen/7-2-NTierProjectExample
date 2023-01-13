using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
 



    public class CategoryManager : ICategoryService 
    {

        private ICategoryService _categoryDal;

        public CategoryManager(ICategoryService categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public List<Category> GetAll()
        {
           return _categoryDal.GetAll();
        }
    }
}
