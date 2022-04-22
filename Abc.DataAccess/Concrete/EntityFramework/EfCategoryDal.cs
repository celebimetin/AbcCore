using Abc.DataAccess.Abstract;
using Abc.Core.DataAccess.EntityFramework;
using Abc.Entities.Concrete;

namespace Abc.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
    }
}