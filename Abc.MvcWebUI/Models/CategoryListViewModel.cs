using Abc.Entities.Concrete;
using System.Collections.Generic;

namespace Abc.MvcWebUI.Models
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get; internal set; }
    }
}