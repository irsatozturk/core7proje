using core7proje.Models;
using Microsoft.AspNetCore.Mvc;

namespace core7proje.Controllers;

public class ArticlesController: Controller
{
    public IActionResult Index(){
        var Article = new ArticlesModel();
        Article.Id = 1;
        Article.Header = "deneme başlık";
        return View(Article);
    }
}
