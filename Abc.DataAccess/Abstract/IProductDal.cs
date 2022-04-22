using Abc.Core.DataAccess;
using Abc.Entities.Concrete;

namespace Abc.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
    }
}