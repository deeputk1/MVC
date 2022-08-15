using System.Collections.Generic;
using Triggerfish.Models;

namespace Triggerfish.Repository
{
    public class NewsArticleRepository:INewsArticleRepository
    {
        /// <summary>
        /// method to return list of articles
        /// </summary>
        /// <returns></returns>
        public List<NewsArticleModel> GetNewsArticles()
        {
            List<NewsArticleModel> newsArticles = new List<NewsArticleModel>();
            // Create 3 article objects with values to the model properties
            newsArticles.Add(new NewsArticleModel
            {
                ArticleTitle = "Why demand for in-store contactless payment is here to stay",
                Description = "The demand for in-store contactless payment technology has increased over the past two years.Learn more about this growing trend and how you can     leverage it.",
                ImageUrl = "https://securecdn.pymnts.com/wp-content/uploads/2019/05/NMI-Contactless-Payments.jpg",
                ReadTime = "4"
            });
            newsArticles.Add(new NewsArticleModel
            {
                ArticleTitle = "7 ways to increase ecommerce sales",
                Description = "Increase ecommerce saleswith these 6 projects to improve your customers's online payment experience.",
                ImageUrl = "https://d2kh7o38xye1vj.cloudfront.net/wp-content/uploads/2018/11/Grow-your-e-commerce-sales.jpg",
                ReadTime = "4"
            });
            newsArticles.Add(new NewsArticleModel
            {
                ArticleTitle = "How technology empowers businesses to prepare for the future of commerce",
                Description = "The future of ecommerce is ever changing. Learn how our future-forwardcommerce technology keeps businesses at the forefront.",
                ImageUrl = "https://www.gomodus.com/hubfs/Blog%20Images/Tech%20Changes%20Business.jpg",
                ReadTime = "4"
            });
            //return list of articles created
            return newsArticles;
        }
    }
}