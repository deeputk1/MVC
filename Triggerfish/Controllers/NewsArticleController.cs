using System.Web.Mvc;
using Triggerfish.Repository;

namespace Triggerfish.Controllers
{
    public class NewsArticleController : Controller
    {
        private readonly INewsArticleRepository _newsArticleRepository;

        public NewsArticleController(NewsArticleRepository newsArticleRepository)
        {
            _newsArticleRepository = newsArticleRepository;
        }
        /// <summary>
        /// Method to render view with list of articles
        /// </summary>
        /// <returns>view file ArticleListing.cshtml</returns>
        public ActionResult RenderNewsArticleList()
        {
            return View("~/Views/ArticleListing.cshtml", _newsArticleRepository.GetNewsArticles());
        }
        
    }
}