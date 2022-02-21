using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Review
{
    public class Management
    {
        //method to retrieve top 3 records
        public void Top3Records(List<ProductReview> listProductReview)
        {
            var recordedData = (from productReviews in listProductReview
                                orderby productReviews.Rating descending
                                select productReviews).Take(3).ToList();
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID: " + list.ProductID + " UserID: " + list.UserID + " Rating: " + list.Rating + " Review: " + list.Review + " isLike: " + list.isLike);
            }
        }
        //retriewe data by condition
        public void RecordWithCondition(List<ProductReview> listProductReview)
        {
            var data = (from productReviews in listProductReview
                        where (productReviews.Rating > 3 && productReviews.ProductID == 1) || (productReviews.Rating > 3 && productReviews.ProductID == 4)
                                || (productReviews.Rating > 3 && productReviews.ProductID == 9)
                        select productReviews).ToList();
            Console.WriteLine("\n");
            foreach (var list in data)
            {
                Console.WriteLine("ProductID: " + list.ProductID + " UserID: " + list.UserID + " Rating: " + list.Rating + " Review: " + list.Review + " isLike: " + list.isLike);
            }
        }
        //method to count
        public void RetrieveCountOfReview(List<ProductReview> listProductReview)
        {
            var data = listProductReview.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, Count = x.Count() });

            Console.WriteLine("\n");
            foreach (var list in data)
            {
                Console.WriteLine(list.ProductID + " ------- " + list.Count);
            }
        }
        //method to retrieve product Id and Product review
        public void RetrieveProductIdAndReview(List<ProductReview> listProductReview)
        {
            var data = from productReviews in listProductReview
                       select new { productReviews.ProductID, productReviews.Review };

            Console.WriteLine("\n");
            Console.WriteLine("\nProductID\tReview");
            foreach (var list in data)
            {
                Console.WriteLine(list.ProductID + " -------------- " + list.Review);
            }
        }
    }
}
