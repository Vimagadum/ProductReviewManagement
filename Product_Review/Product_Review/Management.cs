using System;
using System.Collections.Generic;
using System.Data;
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
        //retrieve data by skipping top 5 record
        public void SkipTop5records(List<ProductReview> listProductReview)
        {
            var data = (from productReviews in listProductReview
                        select productReviews).Skip(5);

            Console.WriteLine("\n");
            foreach (var list in data)
            {
                Console.WriteLine("ProductID: " + list.ProductID + " UserID: " + list.UserID + " Rating: " + list.Rating + " Review: " + list.Review + " isLike: " + list.isLike);
            }
        }
        //creating data Table
        public static DataTable table = new DataTable();
        public void CreateDataTable()
        {
            table.Columns.Add("ProductID");
            table.Columns.Add("UserID");
            table.Columns.Add("Ratings");
            table.Columns.Add("Review");
            table.Columns.Add("IsLike");

            table.Rows.Add(1, 1, 8, "Good", true);
            table.Rows.Add(2, 2, 7, "Good", true);
            table.Rows.Add(3, 3, 5, "Good", true);
            table.Rows.Add(20, 4, 10, "Good", true);
            table.Rows.Add(23, 5, 6, "Nice", false);
            table.Rows.Add(6, 6, 3, "Nice", false);
            table.Rows.Add(20, 7, 2, "Bad", false);
            table.Rows.Add(8, 8, 1, "Nice", false);
            table.Rows.Add(20, 20, 9, "Good", true);
            table.Rows.Add(21, 21, 3, "Nice", false);
            table.Rows.Add(11, 11, 3, "Nice", false);
            table.Rows.Add(14, 14, 10, "Good", true);
            table.Rows.Add(23, 23, 4, "Good", true);

            var stringTable = from product in table.AsEnumerable() select product;

            foreach (var data in stringTable)
            {
                Console.WriteLine("ProductID: " + data.Field<string>("ProductID") + ", UserID: " + data.Field<string>("UserID") + ", Ratings: " + data.Field<string>("Ratings") + " , Review: " + data.Field<string>("Review") + " , IsLike: " + data.Field<string>("IsLike"));
            }
        
        }
    }
}
