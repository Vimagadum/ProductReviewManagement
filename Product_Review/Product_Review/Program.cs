using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Review
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Product Review Management!");
            //creating list
            List<ProductReview> listProductReview = new List<ProductReview>()
            {
                //adding to the list
                new ProductReview(){ProductID=1,UserID=1,Rating=5,Review="Super",isLike=true},
                new ProductReview(){ProductID=2,UserID=3,Rating=4,Review="Great",isLike=true},
                new ProductReview(){ProductID=3,UserID=5,Rating=3,Review="Good",isLike=true},
                new ProductReview(){ProductID=4,UserID=7,Rating=2,Review="Okay",isLike=true},
                new ProductReview(){ProductID=5,UserID=9,Rating=1,Review="Poor",isLike=true},
                new ProductReview(){ProductID=6,UserID=11,Rating=5,Review="Super",isLike=true},
                new ProductReview(){ProductID=7,UserID=13,Rating=4,Review="Great",isLike=true},
                new ProductReview(){ProductID=8,UserID=15,Rating=3,Review="Good",isLike=true},
                new ProductReview(){ProductID=9,UserID=17,Rating=2,Review="Okay",isLike=true},
                new ProductReview(){ProductID=10,UserID=18,Rating=1,Review="Poor",isLike=true},
                new ProductReview(){ProductID=11,UserID=19,Rating=5,Review="Super",isLike=true},
                new ProductReview(){ProductID=12,UserID=21,Rating=4,Review="Great",isLike=true},
                new ProductReview(){ProductID=13,UserID=23,Rating=3,Review="Good",isLike=true},
                new ProductReview(){ProductID=14,UserID=25,Rating=2,Review="Okay",isLike=true},
                new ProductReview(){ProductID=15,UserID=27,Rating=1,Review="Poor",isLike=true},
                new ProductReview(){ProductID=16,UserID=29,Rating=5,Review="Super",isLike=true},
                new ProductReview(){ProductID=17,UserID=31,Rating=4,Review="Great",isLike=true},
                new ProductReview(){ProductID=18,UserID=33,Rating=3,Review="Good",isLike=true},
                new ProductReview(){ProductID=19,UserID=35,Rating=2,Review="Okay",isLike=true},
                new ProductReview(){ProductID=20,UserID=37,Rating=1,Review="Poor",isLike=true},
                new ProductReview(){ProductID=21,UserID=39,Rating=5,Review="Super",isLike=true},
                new ProductReview(){ProductID=22,UserID=41,Rating=4,Review="Great",isLike=true},
                new ProductReview(){ProductID=23,UserID=43,Rating=3,Review="Good",isLike=true},
                new ProductReview(){ProductID=24,UserID=45,Rating=2,Review="Okay",isLike=true},
                new ProductReview(){ProductID=25,UserID=47,Rating=1,Review="Poor",isLike=true},
            };
            //retriewing data from list
            //foreach (var list in listProductReview)
            //{
            //    Console.WriteLine("ProductID: " + list.ProductID + " UserID: " + list.UserID + " Rating: " + list.Rating + " Review: " + list.Review + " isLike: " + list.isLike);
            //}
            Console.WriteLine();
            Management manage = new Management();
            //manage.Top3Records(listProductReview);

            //manage.RecordWithCondition(listProductReview);
            //manage.RetrieveCountOfReview(listProductReview);
            //manage.RetrieveProductIdAndReview(listProductReview);
            //manage.SkipTop5records(listProductReview);
            manage.CreateDataTable();
            //manage.GetAllLikedReviews();
            manage.AverageRatingOfEachProductId(listProductReview);
            Console.ReadLine();
        }
    }
}
