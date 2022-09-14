using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp
{
    public class Product
    {
        private string imagePath;

        public string ImagePath
        {
            get { return imagePath; }
            set { imagePath = value; }
        }
        private string prodyctName;

        public string ProductName
        {
            get { return prodyctName; }
            set { prodyctName = value; }
        }
        private double productPrice;

        public double ProductPrice
        {
            get { return productPrice; }
            set { productPrice = value; }
        }


    }
}
