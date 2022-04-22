using Abc.Entities.Concrete;
using System.Collections.Generic;

namespace Abc.MvcWebUI
{
    public class ProductListViewModel
    {
        public List<Product> Products { get; internal set; }
    }
}