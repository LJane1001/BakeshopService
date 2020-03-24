using System;
using System.Collections.Generic;
using System.Text;

namespace Productsubsystem.Model
{
    public class ProductModel
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<ProductItemModel> Details { get; set; }
    }
}
