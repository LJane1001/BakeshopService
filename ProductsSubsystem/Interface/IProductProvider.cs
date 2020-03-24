using Productsubsystem.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Productsubsystem.Interface
{
    public interface IProductProvider
    {
        List<ProductModel> GetProducts();
    }
}
