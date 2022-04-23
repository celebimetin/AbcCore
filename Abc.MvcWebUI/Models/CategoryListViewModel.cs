using Abc.Entities.Concrete;
using System.Collections.Generic;

namespace Abc.MvcWebUI.Models
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get; set; }
        public int CurrentCategory { get; set; }
    }
}