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
                ImageUrl = "https://i0.wp.com/www.inventiva.co.in/wp-content/uploads/2022/06/shutterstock_744970960.webp?resize=780%2C470&ssl=1",
                ReadTime = "4"
            });
            newsArticles.Add(new NewsArticleModel
            {
                ArticleTitle = "7 ways to increase ecommerce sales",
                Description = "Increase ecommerce saleswith these 6 projects to improve your customers's online payment experience.",
                ImageUrl = "https://i0.wp.com/www.inventiva.co.in/wp-content/uploads/2022/06/shutterstock_744970960.webp?resize=780%2C470&ssl=1",
                ReadTime = "4"
            });
            newsArticles.Add(new NewsArticleModel
            {
                ArticleTitle = "How technology empowers businesses to prepare for the future of commerce",
                Description = "The future of ecommerce is ever changing. Learn how our future-forwardcommerce technology keeps businesses at the forefront.",
                ImageUrl = "https://i0.wp.com/www.inventiva.co.in/wp-content/uploads/2022/06/shutterstock_744970960.webp?resize=780%2C470&ssl=1",
                ReadTime = "4"
            });
            //return list of articles created
            return newsArticles;
        }
    }
}