using System.Web.Mvc;

namespace DocsTemplate.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult SomePage() { return View(); }
        public ActionResult FirstPage() { return View(); }
    }
}