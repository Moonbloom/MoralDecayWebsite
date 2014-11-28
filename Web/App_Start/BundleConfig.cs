using System.Web.Optimization;

namespace Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            #region Core Scripts
            bundles.Add(new ScriptBundle("~/bundles/core/js/header").Include(
                "~/Scripts/core/various/modernizr-{version}.js" // Use the development version of Modernizr to develop with and learn from. Then, when you're ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
                ));

            bundles.Add(new ScriptBundle("~/bundles/core/js/footer").Include(
                "~/Scripts/core/angularjs/angular.js",
                "~/Scripts/core/bootstrap/bootstrap.js",
                "~/Scripts/core/various/respond.js",
                "~/Scripts/core/jquery/jquery-{version}.js",
                "~/Scripts/core/jquery/jquery.validate*"
                ));
            #endregion

            #region Core Styles
            bundles.Add(new StyleBundle("~/bundles/core/css").Include(
                "~/Content/bootstrap/bootstrap.css",
                "~/Content/site.css"
                ));
            #endregion

            #region Optimization
            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = false;
            #endregion
        }
    }
}
