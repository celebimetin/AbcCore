using Abc.Business.Abstract;
using Abc.DataAccess.Abstract;
using Abc.Entities.Concrete;
using System.Collections.Generic;

namespace Abc.Business.Concrete
{
    public class IProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public IProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(int productId)
        {
            //_productDal.Delete(productId);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public List<Product> GetByCategory(int categoryId)
        {
            return _productDal.GetList(p => p.CategoryId == categoryId);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}