using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    internal class ProductManagement
    {
        public static void Top3Records(List<Product> productsReviewList)
        {
            var productdata = (from reviewlist in productsReviewList
                               where reviewlist.Rating == 5
                               select reviewlist).Take(3);
            foreach (var list in productdata)
            {
                Console.WriteLine("ProdcutID " + list.productID + " UserId " + list.UserId + " Rating "
                    + list.Rating + " Review " + list.Review + " IsLike " + list.IsLike);
            }
        }
        public static void AllRecord(List<Product> productsReviewList)
        {
            var productdata = (from reviewlist in productsReviewList
                               where reviewlist.Rating > 3
                               select reviewlist);


            foreach (var list in productdata)
            {
                Console.WriteLine("ProdcutID " + list.productID + " UserId " + list.UserId + " Rating "
                    + list.Rating + " Review " + list.Review + " IsLike " + list.IsLike);
            }

        }
        public static void RetriveFromProductId(List<Product> productsReviewList)
        {
            var productdata = (from reviewlist in productsReviewList
                               where reviewlist.productID == 1 || reviewlist.productID == 4 || reviewlist.productID == 9
                               select reviewlist);


            foreach (var list in productdata)
            {
                Console.WriteLine("ProdcutID " + list.productID + " UserId " + list.UserId + " Rating "
                    + list.Rating + " Review " + list.Review + " IsLike " + list.IsLike);
            }

        }
        public static void RetriveProductIdAndReview(List<Product> productsReviewList)
        {
            var productdata = productsReviewList.Select(product => new { ProductId = product.productID, Review = product.Review }).ToList();


            foreach (var list in productdata)
            {
                Console.WriteLine("ProdcutID " + list.ProductId + " Review " + list.Review);
            }

        }
    }
}
