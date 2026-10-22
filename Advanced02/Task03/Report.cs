using Advanced02.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced02.Task03
{
    public class Report
    {
        public static void PrintReport(List<Product> products , Action<Product> sammary)
        {
            foreach (var product in products)
            {
                sammary(product); 
            }
        }
    }
}
