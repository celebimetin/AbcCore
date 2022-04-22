using Abc.Core.DataAccess;
using Abc.Entities.Concrete;

namespace Abc.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
    }
}