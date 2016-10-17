using System.Web.Optimization;

namespace SimpleBlog
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Admin/Styles")
                .Include("~/Content/Styles/bootstrap.css")
                .Include("~/Content/Styles/admin.css"));

            bundles.Add(new StyleBundle("~/Styles")
                .Include("~/Content/Styles/bootstrap.css")
                .Include("~/Content/Styles/site.css"));

            bundles.Add(new ScriptBundle("~/Admin/Scripts")
                .Include("~/Scripts/jqurey-3.1.0.js")
                .Include("~/Scripts/jquery.validate.js")
                .Include("~/Scripts/jquery.validate.unobtrusive.js")
                .Include("~/Scripts/bootstrap.js")
                .Include("~/Areas/Admin/Scripts/Forms.js"));

            bundles.Add(new ScriptBundle("~/Scripts")
                .Include("~/Scripts/jqurey-3.1.0.js")
                .Include("~/Scripts/jquery.validate.js")
                .Include("~/Scripts/jquery.validate.unobtrusive.js")
                .Include("~/Scripts/bootstrap.js"));

        }
    }
}
