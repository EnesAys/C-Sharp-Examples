using System.Web;
using System.Web.Optimization;

namespace Teknik.MVC
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            #region AdminBundleStyle

            bundles.Add(new StyleBundle("~/admin/bundles/css").Include(
                "~/Areas/admin/resources/css/reset.css",
                "~/Areas/admin/resources/css/style.css",
                "~/Areas/admin/resources/css/invalid.css"
                ));

            #endregion

            #region AdminBundleScripts

            bundles.Add(new ScriptBundle("~/admin/bundles/script").Include(
                "~/Areas/admin/resources/scripts/jquery-1.3.2.min.js",
                "~/Areas/admin/resources/scripts/simpla.jquery.configuration.js",
                "~/Areas/admin/resources/scripts/facebox.js",
                "~/Areas/admin/resources/scripts/jquery.wysiwyg.js",
                "~/Areas/admin/resources/scripts/jquery.datePicker.js",
                "~/Areas/admin/resources/scripts/jquery.date.js"
                ));

            #endregion

            #region SiteScript

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            #endregion

            #region SiteCss
            bundles.Add(new StyleBundle("~/Content/css").Include(
                     "~/Content/bootstrap.css",
                     "~/Content/site.css"));
            #endregion

            //optimize et
            BundleTable.EnableOptimizations = true;
        }
    }
}
