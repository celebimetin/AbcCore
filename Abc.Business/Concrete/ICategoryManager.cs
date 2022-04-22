using Abc.Business.Abstract;
using Abc.DataAccess.Abstract;
using Abc.Entities.Concrete;
using System.Collections.Generic;

namespace Abc.Business.Concrete
{
    public class ICategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public ICategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Delete(int categoryId)
        {
            //_categoryDal.Delete(categoryId);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}