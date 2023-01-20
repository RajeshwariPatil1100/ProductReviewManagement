using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    internal class Count
    {
        public static void CountOfProduct(List<Product> productsReviewList)
        {
            var res = from C in productsReviewList
                      group C by C.Review;

            foreach (var val in res)
            {

                Console.WriteLine("Group By Review: {0}", "Count of Review{1}", val.Key);

                foreach (Product C in val)
                {
                    Console.WriteLine("ProductId: {0}",
                                               C.productID);
                }
            }
        }
    }
}
