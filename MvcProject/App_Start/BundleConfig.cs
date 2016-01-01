using System.Web.Optimization;

namespace DocsTemplate
{
    public class BundleConfig 
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.IgnoreList.Clear(); // allow adding minified js files
            //BundleTable.EnableOptimizations = true; 
            // Styles
            bundles.Add(new StyleBundle("~/css/bootstrap-docs").Include(
                "~/css/bootstrap.min.css",
                "~/css/docs.min.css"
            ));
            bundles.Add(new StyleBundle("~/css/prism").Include(
                "~/css/prism.min.css"
            ));
            bundles.Add(new StyleBundle("~/css/custom").Include(
                "~/css/custom.css"
            ));
            // Scripts
            bundles.Add(new ScriptBundle("~/js/jquery").Include(
                "~/js/jquery.min.js"
            ));
            bundles.Add(new ScriptBundle("~/js/bootstrap-docs").Include(
                "~/js/bootstrap.min.js",
                "~/js/docs.min.js"
            ));
            bundles.Add(new ScriptBundle("~/js/prism").Include(
                "~/js/prism.min.js"
            ));
            bundles.Add(new ScriptBundle("~/js/hacks").Include(
                "~/js/ie10-viewport-bug-workaround.js"
            ));
            bundles.Add(new ScriptBundle("~/js/custom").Include(
                "~/js/custom.js"
            ));
        }
    }
}
