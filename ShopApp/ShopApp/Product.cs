using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp
{
    public class Product
    {
        public string Designation { get; set; }
        public string Status { get; set; }
        public string Price { get; set; }
        public string Image { get; set; }
        public bool IsVisible { get; set; }
        public string Category { get; set; }

    }
    public class ProductPair : Tuple<Product, Product>
    {
        public ProductPair(Product item1, Product item2)
            : base(item1, item2 ?? CreateEmptyModel()) { }

        private static Product CreateEmptyModel()
        {
            return new Product { IsVisible = false };
        }
    }

}
