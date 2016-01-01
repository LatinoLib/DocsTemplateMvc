using System.Web.Http.Filters;
using System.Web.Mvc;

namespace DocsTemplate
{
    public class GlobalViewBagActionFilter : System.Web.Mvc.ActionFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            filterContext.Controller.ViewBag.ProjectName = "Project Name";
            filterContext.Controller.ViewBag.ProjectDescription = "Project Description";
            filterContext.Controller.ViewBag.ProjectKeywords = "Project Keywords";
            filterContext.Controller.ViewBag.ProjectAuthors = "Project Authors";
            filterContext.Controller.ViewBag.GitHubBaseUrl = "https://github.com/me/project";
            filterContext.Controller.ViewBag.CurrentVersion = "1.0";
        }
    }
}