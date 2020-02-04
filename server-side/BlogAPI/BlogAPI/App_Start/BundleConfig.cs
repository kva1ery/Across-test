using System.Web;
using System.Web.Optimization;

namespace BlogAPI
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                "~/Scripts/app/app.js",
                "~/Scripts/app/core/core.module.js",
                "~/Scripts/app/core/article/article.module.js",
                "~/Scripts/app/core/article/article.service.js",
                "~/Scripts/app/article-list/article-list.module.js",
                "~/Scripts/app/article-list/article-list.component.js",
                "~/Scripts/app/article-detail/article-detail.module.js",
                "~/Scripts/app/article-detail/article-detail.component.js",
                "~/Scripts/app/article-form/article-form.module.js",
                "~/Scripts/app/article-form/article-form.component.js"));

            bundles.Add(new ScriptBundle("~/bundles/materialize").Include(
                "~/Scripts/materialize.js"));

            bundles.Add(new ScriptBundle("~/bundles/angularjs").Include(
                      "~/Scripts/angular.js",
                      "~/Scripts/angular-route.js",
                      "~/Scripts/angular-resource.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                     "~/Content/materialize.css",
                      "~/Content/app.css"));
        }
    }
}
