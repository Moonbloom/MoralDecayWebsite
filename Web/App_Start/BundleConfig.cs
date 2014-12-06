using System.Web.Optimization;

namespace Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            #region Core scripts
            bundles.Add(new ScriptBundle("~/bundles/core/js/header").Include(
                "~/Scripts/core/angular/angular.js",
                "~/Scripts/angular/bodyCtrl.js",
                // Use the development version of Modernizr to develop with and learn from. Then, when you're ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
                "~/Scripts/core/various/modernizr-{version}.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/core/js/footer").Include(
                "~/Scripts/core/bootstrap/bootstrap.js",
                "~/Scripts/core/jquery/jquery-{version}.js",
                "~/Scripts/core/jquery/jquery.validate*"
                ));
            #endregion

            #region Core styles
            bundles.Add(new StyleBundle("~/bundles/core/css").Include(
                "~/Content/bootstrap/bootstrap.css",
                "~/Content/site.css"
                ));
            #endregion

            #region Optimization
            // Set EnableOptimizations to false for debugging. For more information visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = false;
            #endregion

            #region Page specific script bundles
            bundles.Add(new ScriptBundle("~/bundles/view/frontpage").Include(
                "~/Scripts/angular/frontpage/frontpageCtrl.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/view/recruiting").Include(
                "~/Scripts/angular/recruiting/recruitingCtrl.js",
                "~/Scripts/angular/back-img-directive.js"
                ));
            #endregion
        }
    }
}
