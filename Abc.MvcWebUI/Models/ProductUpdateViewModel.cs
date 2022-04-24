using Abc.Entities.Concrete;
using System.Collections.Generic;

namespace Abc.MvcWebUI.Models
{
    public class ProductUpdateViewModel
    {
        public Product Product { get; internal set; }
        public List<Category> Categories { get; internal set; }
    }
}