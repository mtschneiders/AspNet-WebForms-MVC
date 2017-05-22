using System.Web.Optimization;

namespace WebApp.App_Start
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            RegisterStyleBundles(bundles);
            RegisterScriptBundles(bundles);
        }

        private static void RegisterStyleBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                     "~/Content/bootstrap.css",
                     "~/Content/themes/base/jquery-ui.min.css",
                     "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/gridmvc").Include(
                     "~/Content/Gridmvc.css"));
        }

        private static void RegisterScriptBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/gridmvc").Include(
                      "~/Scripts/ladda-bootstrap/*.min.js",
                      "~/Scripts/URI.js",
                      "~/Scripts/gridmvc.min.js",
                      "~/Scripts/gridmvc-ext.js",
                      "~/Scripts/gridmvc.customwidgets.js"));

            bundles.Add(new ScriptBundle("~/bundles/application/customer").Include(
                      "~/Scripts/Application/Customer.js"));
        }
    }
}