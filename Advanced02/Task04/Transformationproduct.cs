using Advanced02.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced02.Task04
{
    public class Transformationproduct
    {
        public static List<T> TransformProducts <T> (List<Product> products, Func<Product,T> sammary )
        { 
            List<T> result = new List<T>();
            foreach (Product product in products) 
            {
               result.Add( sammary(product) );
            }
            return result;
        }
        
    }
}
