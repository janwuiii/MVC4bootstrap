using System.Web;
using System.Web.Optimization;

namespace MyTecBits_Bootstrap_MVC
{
    public class BundleConfig
    {

        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.IgnoreList.Clear();

            bundles.Add(new ScriptBundle("~/Bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/Bundles/bootstrapjs").Include(
                        "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Bundles/bootstrapcss").Include(
                        "~/Content/bootstrap.css",
                        "~/Content/bootstrap-theme.css",
                        "~/Content/justified-nav.css"));
        }
    }
}