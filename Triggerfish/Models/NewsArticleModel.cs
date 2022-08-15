using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Triggerfish.Models
{
    public class NewsArticleModel
    {
        public string ArticleTitle { get; set; }
        public string Description { get; set; }
        public string ReadTime { get; set; }
        public string ImageUrl { get; set; }
    }
}