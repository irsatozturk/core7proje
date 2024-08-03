using core7proje.Models;
using Microsoft.AspNetCore.Mvc;

namespace core7proje.Controllers;

public class ArticleController: Controller
{
    public IActionResult Index()
    {
        var Article = new ArticleModel();
        Article.Id = 1;
        Article.Header = "tek data başlığı xx";
        Article.Description = "tek data açıklaması";
        Article.Image="1.jpg";
        return View(Article);
    }

    public IActionResult ArticleDataList(){
        var ArticleDataList = new List<ArticleModel>()
        {
            new ArticleModel() { Id=1, Header=" başlık1", Description="açıklama 1", Image="1.jpg" },
            new ArticleModel() { Id=2, Header=" başlık2", Description="açıklama 2", Image="2.jpg" },
            new ArticleModel() { Id=3, Header=" başlık3", Description="açıklama 3", Image="3.jpg" },
        };
        return View("ArticleList", ArticleDataList);
    }
}
