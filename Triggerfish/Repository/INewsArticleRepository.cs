using System.Collections.Generic;
using Triggerfish.Models;

namespace Triggerfish.Repository
{
    interface INewsArticleRepository
    {
        List<NewsArticleModel> GetNewsArticles();
    }
}
