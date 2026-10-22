using Advanced02.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced02.task05
{
    public class filltrationProduct
    {
        public static List<Product> FilterProducts(List<Product> products, Predicate<Product> condition)
        {
            List<Product> result = new List<Product>();
            foreach (Product product in products) 
            {
                if (condition(product))
                {
                    result.Add(product);
                }
                return result;
            }
            return result;

        }
    }
}
