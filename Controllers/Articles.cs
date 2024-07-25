using Microsoft.AspNetCore.Mvc;

namespace core7proje.Controllers;

public class ArticlesController: Controller
{
    public IActionResult Index(){
        return View();
    }
    public string Liste(){
        return "Listsdasde isimli action çalıştı.";
    }

}
