using Microsoft.AspNetCore.Mvc;

namespace CoreIntroOfAspNet.Controllers
{
    public class CoreIntroOfAspNet : Controller
    {
        string[] ToDo = { "task to do 1", "task to do 2", "task to do 3" };//массив дел для выполнения
        public IActionResult Index()
        {
            ViewData["cases"] = this.ToDo;//объект библиотеки, в который добавляется информация, которая становится доступной для отображения на странице
            return View();
        }
    }
}