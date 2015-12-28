using System.Web.Http.Filters;
using System.Web.Mvc;

namespace DocsTemplate
{
    public class GlobalViewBagActionFilter : System.Web.Mvc.ActionFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            filterContext.Controller.ViewBag.ProjectName = "LATINO";
            filterContext.Controller.ViewBag.ProjectDescription = "LATINO is a light-weight framework for building text mining applications.";
            filterContext.Controller.ViewBag.ProjectKeywords = "put some keywords here";
            filterContext.Controller.ViewBag.ProjectAuthors = "Miha Grčar & contributors";
            filterContext.Controller.ViewBag.GitHubBaseUrl = "https://github.com/SowaLabs/LATINO";
        }
    }
}