using Abc.Entities.Concrete;
using System.Collections.Generic;

namespace Abc.MvcWebUI.Models
{
    public class ProductAddViewModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; internal set; }
    }
}