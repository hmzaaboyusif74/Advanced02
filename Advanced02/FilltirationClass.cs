using Advanced02.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced02
{
    public class FilltirationClass
    {
    
        public static List<Product> SearchProducts(List<Product> products, Func<Product, bool> fillter)
        {
            List<Product> result = new List<Product>();
            foreach(Product product in products)
            {
                if (fillter(product))
                {
                    result.Add(product);
                }
            }
           return result;

        }

       


}
}
