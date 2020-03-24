using System;
using System.Collections.Generic;
using System.Text;

namespace Productsubsystem.Model
{
    public class ProductItemModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
    }
}
