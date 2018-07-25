using System.Web;
using System.Web.Optimization;

namespace ContactsApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {


            bundles.Add(new StyleBundle("~/Content/CSS/Bootstrap").Include(
                      "~/Content/CSS/bootstrap.css"));

            bundles.Add(new StyleBundle("~/Content/CSS/Styles").Include(
                       "~/Content/CSS/Styles.css"));

            bundles.Add(new ScriptBundle("~/Scripts/Jquery").Include(
                "~/Scripts/Jquery/jquery-3.3.1.js"));

            bundles.Add(new ScriptBundle("~/Scripts/Bootstrap").Include(
                        "~/Scripts/Bootstrap/bootstrap.js"));

        }
    }
}
