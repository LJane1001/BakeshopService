using Productsubsystem.Interface;
using Productsubsystem.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Productsubsystem.Concrete
{
    public class ProductProvider : IProductProvider
    {
        public List<ProductModel> GetProducts()
        {
            var productList = new List<ProductModel>();
            productList.Add(GetCakeProducts());

            return productList;
        }

        private ProductModel GetCakeProducts()
        {
            return new ProductModel()
            {
                CategoryId = 1,
                CategoryName = "Cake",
                Details = GetCakes()
            };
        }

        private List<ProductItemModel> GetCakes()
        {
            return new List<ProductItemModel>() { 
                new ProductItemModel(){ 
                                        Id = 1,
                                        Name = "Strawberry Cake",
                                        Price = 500.00,
                                        ImageUrl = "assets/Images/strawberryCake.png",
                                        CategoryId = 1
                                      },
                new ProductItemModel(){
                                        Id = 2,
                                        Name = "Chocolate Cake",
                                        Price = 450.00,
                                        ImageUrl = "assets/Images/chocolateCake.png",
                                        CategoryId = 1
                                      }
            };
        }
    }
}
