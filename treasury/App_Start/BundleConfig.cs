using System.Web;
using System.Web.Optimization;

namespace treasury
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/TemplateJs").Include(
                "~/js/lib/jquery/jquery.min.js",
                "~/js/lib/bootstrap/js/popper.min.js",
                "~/js/lib/bootstrap/js/bootstrap.min.js",
                "~/js/jquery.slimscroll.js",
                "~/js/sidebarmenu.js",
                "~/js/lib/sticky-kit-master/dist/sticky-kit.min.js",
                "~/js/custom.min.js"));

            bundles.Add(new StyleBundle("~/TemplateCss").Include(
                "~/css/lib/bootstrap/bootstrap.min.css",
                "~/css/helper.css",
                "~/css/style.css")); 

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
