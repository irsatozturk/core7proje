using core7proje.Models;
using Microsoft.AspNetCore.Mvc;

namespace core7proje.Controllers;

public class ArticleController: Controller
{
    public IActionResult Index()
    {
        var Article = new ArticleModel();
        Article.Id = 1;
        Article.Header = "deneme başlık";
        Article.Description = "açıklama mesajı örneği";
        return View(Article);
    }

    public IActionResult ArticleList(){
        var ArticleDataList = new List<ArticleModel>()
        {
            new ArticleModel() { Id=1, Header=" başlık1", Description="açıklama 1", Image="1.jpg" },
            new ArticleModel() { Id=2, Header=" başlık2", Description="açıklama 2", Image="2.jpg" },
            new ArticleModel() { Id=3, Header=" başlık3", Description="açıklama 3", Image="3.jpg" },
        };
        return View("ArticleList", ArticleDataList);
    }
}
